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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3(List<User> History)
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            chart1.Series["Series1"].LegendText = "Шаги";
            chart1.Series["Series2"].LegendText = " ";
            foreach (var item in History)
            {
                chart1.Series["Series1"].Points.AddXY(item.Date, item.Step);
            }
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
        }
    }
}