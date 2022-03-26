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
// крутилку на загрузку данных
// Окно с результатами анализа (наиболее активный день, наименее активный день, среднее количество пройденных шагов)

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private readonly DataProcessor _dataProcessor;
        private readonly List<ActivityInfo> _persons;

        public Form3(List<User> History)
        {
            InitializeComponent();
            ImportAppleHealthFileDialog.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            
            //chart1.Series["Series1"].LegendText = "Шаги";
            //chart1.Series["Series2"].LegendText = " ";
            //foreach (var item in History)
            //{
            //    chart1.Series["Series1"].Points.AddXY(item.Date, item.Step);
            //}

            _dataProcessor = new DataProcessor();
            _persons = new List<ActivityInfo>();
        }

        //Массивы для хранения
        List<string> x;
        List<int> y;
        int[] a;
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
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
                    chart1.Series["Series1"].Points.Clear();
                    chart1.Series["Series2"].Points.Clear();
                    chart1.Series["Series1"].LegendText = "Шаги из файла";
                    chart1.Series["Series2"].LegendText = " ";
                    for (int i = 0; i < x.Count; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(x[i], y[i]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Некорректные данные!\n\nПример ввода:\nдата,кол-во шагов\nдата,кол-во шагов\nдата,кол-во шагов", "Ошибка ввода");
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            //Начинаем запись в файл
            StreamWriter sw = new StreamWriter(filename);
            foreach (int val in a)

                sw.WriteLine(val);
            sw.Close();
            MessageBox.Show("Файл сохранен");
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
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
                    chart1.Series["Series1"].Points.Clear();
                    chart1.Series["Series2"].Points.Clear();
                    chart1.Series["Series1"].LegendText = "Шаги 1-го участника";
                    chart1.Series["Series2"].LegendText = "Шаги 2-го участника";
                    for (int i = 0; i < x.Count - 1; i += 2)
                    {
                        chart1.Series["Series1"].Points.AddXY(x[i], y[i]);
                        chart1.Series["Series2"].Points.AddXY(x[i + 1], y[i + 1]);
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
            var series = chart1.Series.FindByName(seriesName);

            if (series == default)
            {
                series = chart1.Series.Add(seriesName);
                series.Color = Helpers.ColorConverter.ToDrawingColor(person.Color);
                series.LegendText = person.Name;
                series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }

            return series;
        }

        private void SortChartDataButton_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker2.Value;

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
            return chart1.Series.FindByName(person.Id.ToString());
        }
    }
}