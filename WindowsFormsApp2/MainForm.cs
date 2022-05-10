using SportCompanion.Core;
using SportCompanion.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private readonly DataProcessor _dataProcessor;
        private readonly AnalyzeProcessor _analyzeProcessor;
        private readonly List<ActivityInfo> _persons;

        public MainForm()
        {
            InitializeComponent();
            ImportAppleHealthFileDialog.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";

            openFileDialog1.FileName = "data.json";
            openFileDialog1.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            
            saveFileDialog1.FileName = "data.json";
            saveFileDialog1.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            
            MainChart.Series.Clear();

            _dataProcessor = new DataProcessor();
            _analyzeProcessor = new AnalyzeProcessor();
            _persons = new List<ActivityInfo>();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = _dataProcessor.LoadData(openFileDialog1.FileName);
                    if (data == null)
                    {
                        throw new ApplicationException("Файл не найден");
                    }

                    _persons.Clear();
                    _persons.AddRange(data);

                    MainChart.Series.Clear();
                    foreach (var person in _persons)
                    {
                        var series = CreateSeries(person);
                    }
                    ApplyLast7DaysFilter();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = saveFileDialog1.FileName;

                    _dataProcessor.SaveData(path, _persons);

                    MessageBox.Show("Файл успешно сохранен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            Import();
        }
        private void ImportLastMonthBtn_Click(object sender, EventArgs e)
        {
            var limit = DateTime.Today.AddMonths(-1);
            Import(limit);
        }

        private void Import(DateTime? limit = null)
        {
            if (ImportAppleHealthFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var path = ImportAppleHealthFileDialog.FileName;
                    var data = _dataProcessor.Import(path, limit);


                    AddChartDialog addChartDialog = new AddChartDialog();
                    if (addChartDialog.ShowDialog() == DialogResult.OK)
                    {
                        var person = addChartDialog.DialogResultData;
                        person.Steps = data.Steps;
                        person.Energy = data.Energy;

                        _persons.Add(person);

                        var series = CreateSeries(person);

                        ApplyLast7DaysFilter();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка импорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApplyLast7DaysFilter()
        {
            var startDate = DateTime.Today.AddDays(-7);
            DateInputFrom.Value = startDate;

            var endDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            DateInputTo.Value = endDate;

            ApplyFilter(startDate, endDate);
        }

        private void ResetFilter()
        {
            foreach (var person in _persons)
            {
                var series = GetSeries(person);
                if (series != null)
                {
                    series.Points.Clear();
                    FillSeries(series, person.Steps);
                }
            }

            try
            {
                var startDate = _persons.Min(a => a.Steps.MinDate);
                var endDate = _persons.Max(a => a.Steps.MaxDate);

                DateInputFrom.Value = startDate ?? DateTime.Today;
                DateInputTo.Value = endDate ?? DateTime.Today;
            }
            catch (Exception ex)
            {
                DateInputFrom.Value = DateTime.Today;
                DateInputTo.Value = DateTime.Today;
            }

            IsFilterEnabled.Checked = false;
        }

        private void ResetFilterButton_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        private void FillSeries(System.Windows.Forms.DataVisualization.Charting.Series series, IEnumerable<StepInfo> steps)
        {
            foreach (var item in steps)
            {
                series.Points.AddXY(item.Date, item.Value);
            }
        }

        private System.Windows.Forms.DataVisualization.Charting.Series CreateSeries(ActivityInfo person)
        {
            string seriesName = person.Id.ToString();
            var series = MainChart.Series.FindByName(seriesName);

            if (series == default)
            {
                series = MainChart.Series.Add(seriesName);
                series.Color = Helpers.ColorConverter.ToDrawingColor(person.Color);
                series.LegendText = person.Name;
                series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }

            return series;
        }

        private void ApplyFilter(DateTime startDate, DateTime endDate)
        {
            foreach (var person in _persons)
            {
                var series = GetSeries(person);
                if (series != default)
                {
                    series.Points.Clear();
                    var steps = person.Steps.Where(s => s.Date >= startDate && s.Date <= endDate).ToList();

                    FillSeries(series, steps);
                }
            }

            IsFilterEnabled.Checked = true;
        }

        private System.Windows.Forms.DataVisualization.Charting.Series GetSeries(ActivityInfo person)
        {
            return MainChart.Series.FindByName(person.Id.ToString());
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            if (!_persons.Any())
            {
                MessageBox.Show("Отсутствуют данные", "Операция невозможна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var startDate = DateInputFrom.Value;
            var endDate = DateInputTo.Value;

            var result = new List<AnalyzeResult>();
            foreach (var person in _persons)
            {
                var res = _analyzeProcessor.Analyze(person, startDate, endDate);
                result.Add(res);
            }

            AnalyzeForm analyzeForm = new AnalyzeForm(result);
            analyzeForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SPCompanion\nВерсия 1.0\n\nАвтор программы:\nСтудент ТГПУ им. Л.Н. Толстого\nФакультета математики, физики и информатики\nГруппы 2ИС (181001)\nИванов Олег\n\n2020-2022©", "О программе");
        }

        private void DateInputTo_ValueChanged(object sender, EventArgs e)
        {
            var startDate = DateInputFrom.Value;
            var endDate = DateInputTo.Value;

            ApplyFilter(startDate, endDate);
        }

        private void DateInputFrom_ValueChanged(object sender, EventArgs e)
        {
            var startDate = DateInputFrom.Value;
            var endDate = DateInputTo.Value;

            ApplyFilter(startDate, endDate);
        }
    }
}