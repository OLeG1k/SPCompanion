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

// TODO:
// Единый формат файла после сохранения + сохранени json
// Диалог добавления данных пользователя (с выбором цвета линии, имени легенды итд) done[v]
// Окно с результатами анализа (наиболее активный день, наименее активный день, среднее количество пройденных шагов) done[v]

/*
Общая инофрмация
    Среднее количество шагов в день
    Примерно пройденная дистанция с учётом роста человека
    Норма ккал в день
    Оценка активности
    Рассчитанный идеальный вес + относительность
    Максимальное/минимальное кол-во шагов


Наиболее (наименее) активный день 
    Дата
    Количество шагов
    Процент прибавки относительно среднего количества шагов
 
Процент выполнения 
 
 активность по проценту
 
 */

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

        //Массивы для хранения
        List<string> x;
        List<int> y;
        int[] a;
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
                        ResetFilter();
                    }
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

        private void режимСравненияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Инициализация массивов
                    x = new List<string>();
                    y = new List<int>();

                    //Чтение файла и запись значений в List x и y
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string line;
                    string[] line2;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line2 = line.Split(','); //разбиваем строку на подстроки
                        x.Add(Convert.ToString(line2[0]));
                        y.Add(Convert.ToInt32(line2[1]));
                    }
                    sr.Close();

                    //Заполняем график считанными значениями
                    MainChart.Series["Series1"].Points.Clear();
                    MainChart.Series["Series2"].Points.Clear();
                    MainChart.Series["Series1"].LegendText = "Шаги 1-го участника";
                    MainChart.Series["Series2"].LegendText = "Шаги 2-го участника";
                    for (int i = 0; i < x.Count - 1; i += 2)
                    {
                        MainChart.Series["Series1"].Points.AddXY(x[i], y[i]);
                        MainChart.Series["Series2"].Points.AddXY(x[i + 1], y[i + 1]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Некорректные данные!\n\nПример ввода:\n(1-ый участник)дата,кол-во шагов\n(2-ой участник)дата,кол-во шагов\n(1-ый участник)дата,кол-во шагов\n(2-ой участник)дата,кол-во шагов", "Ошибка ввода");
                }
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if (ImportAppleHealthFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var path = ImportAppleHealthFileDialog.FileName;
                    var data = _dataProcessor.Import(path);


                    AddChartDialog addChartDialog = new AddChartDialog();
                    if (addChartDialog.ShowDialog() == DialogResult.OK)
                    {
                        var person = addChartDialog.DialogResultData;
                        person.Steps = data;

                        _persons.Add(person);

                        var series = CreateSeries(person);

                        ResetFilter();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка импорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void SortChartDataButton_Click(object sender, EventArgs e)
        {
            var startDate = DateInputFrom.Value;
            var endDate = DateInputTo.Value;

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

            var result = new List<AnalyzeResult>();
            foreach (var person in _persons)
            {
                var res = _analyzeProcessor.Analyze(person);
                result.Add(res);
            }

            AnalyzeForm analyzeForm = new AnalyzeForm(result);
            analyzeForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:\n\nСтудент Тульского Государственного Педагогического Университета\nФакультета математики, физики и информатики\nГруппы 2ИС (181001)\nИванов Олег", "Об авторе");
        }
    }
}