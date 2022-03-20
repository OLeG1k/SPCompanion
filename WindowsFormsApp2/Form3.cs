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

// TODO:
// Единый формат файла после сохранения + сохранени json
// Диалог добавления данных пользователя (с выбором цвета линии, имени легенды итд)
// крутилку на загрузку данных
// Окно с результатами анализа (наиболее активный день, наименее активный день, среднее количество пройденных шагов)

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private readonly DataProcessor _dataProcessor;

        public Form3(List<User> History)
        {
            InitializeComponent();
            ImportAppleHealthFileDialog.Filter = "Xml files(*.xml)|*.xml|All files(*.*)|*.*";

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            chart1.Series["Series1"].LegendText = "Шаги";
            chart1.Series["Series2"].LegendText = " ";
            foreach (var item in History)
            {
                chart1.Series["Series1"].Points.AddXY(item.Date, item.Step);
            }

            _dataProcessor = new DataProcessor();
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
                var path = ImportAppleHealthFileDialog.FileName;
                var data = _dataProcessor.Import(path);

                var s1 = chart1.Series.FindByName("s1");
                
                if (s1 == default)
                {
                    s1 = chart1.Series.Add("s1");
                    s1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                }
                else
                {
                    s1.Points.Clear();
                }

                s1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                foreach (var item in data)
                {
                    s1.Points.AddXY(item.Key, item.Value);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker2.Value;

            var s1 = chart1.Series.FindByName("s1");
            if (s1 != default)
            {
                var points = s1.Points.Where(p =>
                {
                    var date = DateTime.FromOADate(p.XValue);
                    return date >= startDate && date <= endDate;
                }).ToList();

                s1.Points.Clear();

                foreach (var item in points)
                {
                    s1.Points.AddXY(item.XValue, item.YValues.First());
                }
            }
        }
    }
}