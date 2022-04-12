using SportCompanion.Core;
using SportCompanion.Core.Models;
using SportCompanion.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly AnalyzeProcessor _analyzeProcessor;
        public Form1()
        {
            InitializeComponent();
            List<Person> people = new List<Person>
            {
                new Person { Gender=Human.Male, Name="Мужчина"},
                new Person { Gender=Human.Female, Name="Женщина"},
            };

            comboBox1.DataSource = people;
            comboBox1.DisplayMember = nameof(Person.Name);
            comboBox1.ValueMember = nameof(Person.Gender);

            _analyzeProcessor = new AnalyzeProcessor();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(textBox5.Text);
               
                double height = Convert.ToDouble(textBox1.Text);
                double weight = Convert.ToDouble(textBox4.Text);

                int step = Convert.ToInt32(textBox3.Text);
                var gender = (Human)comboBox1.SelectedValue;

                var activityInfo = new ActivityInfo
                {
                    Age = age,
                    Gender = gender,
                    Height = height,
                    Weight = weight
                };

                double idealWeight = _analyzeProcessor.CalculateIdealWeight(activityInfo);
                double kkalPerDay = _analyzeProcessor.CalculateRecommendKkalPerDay(activityInfo);
                string mark = _analyzeProcessor.AnalyzeSteps(step).Label;

                idealWeight = Math.Round(idealWeight, 2);
                kkalPerDay = Math.Round(kkalPerDay, 2);


                textBox8.Text = mark;
                textBox2.Text = idealWeight.ToString();
                textBox6.Text = kkalPerDay.ToString();

                //DateTime dt = DateTime.Now;
                //string curDate = dt.ToShortDateString();
                //User ss = new User 
                //{ 
                //    Age = age, 
                //    Ccal_per_day = kkalPerDay, 
                //    Gender = comboBox1.Text, 
                //    Height = height, 
                //    Ideal_weight = idealWeight, 
                //    Weight = weight, 
                //    Date = curDate, 
                //    Step = step, 
                //    Mark = mark 
                //};
                ////var mass = new List<User>();
                ////mass.Add(ss);
                ////Properties.Settings.Default.History = JsonConvert.SerializeObject(History);
                ////Properties.Settings.Default.Save();
                //string History_JSON = Properties.Settings.Default.History;
                //var Histories = JsonConvert.DeserializeObject<List<User>>(History_JSON);
                //int index = Histories.FindIndex((k) => k.Date == curDate);
                //if (index == -1)
                //{
                //    Histories.Add(ss);
                //}
                //else
                //{
                //    Histories[index] = ss;
                //}
                //Properties.Settings.Default.History = JsonConvert.SerializeObject(Histories);
                //Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Данные заполнены некорректно!", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddChartDialog addChartDialog = new AddChartDialog();
            addChartDialog.ShowDialog();
            MessageBox.Show("Автор программы:\n\nСтудент Тульского Государственного Педагогического Университета\nФакультета математики, физики и информатики\nГруппы 2ИС (181001)\nИванов Олег", "Об авторе");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm History = new MainForm();
            History.ShowDialog();
        }
    }
}
