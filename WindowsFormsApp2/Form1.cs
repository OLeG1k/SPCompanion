using Newtonsoft.Json;
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
        public Form1()
        {
            InitializeComponent();
            List<Person> people = new List<Person>
            {
        new Person { Gender=Human.male, Name="Мужчина"},
        new Person { Gender=Human.female, Name="Женщина"},
        };
         
            comboBox1.DataSource = people;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Gender";
        }
    
 
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Age = Convert.ToInt32(textBox5.Text);
                double Ideal_weight = 0;
                double Height = Convert.ToDouble(textBox1.Text);
                double Weight = Convert.ToDouble(textBox4.Text);
                double Ccal_per_day = 0;
                int Step = Convert.ToInt32(textBox3.Text);
                string Result = "";
                if (Step < 2500)
                {
                    Result = "Очень плохая активность";

                }
                else if (Step < 5000)
                {
                    Result = "Плохая активность";
                }
                else if (Step < 7500)
                {
                    Result = "Нормальная активность";
                }
                else if (Step < 10000)
                {
                    Result = "Отличная активность";
                }
                else
                {
                    Result = "Потрясающая активность!";
                }
                textBox8.Text = Result;

                if ((Human)comboBox1.SelectedValue == Human.male)
                {
                    //мужчина
                    Ideal_weight = ((Height * 4 / 2.54 - 128) * 0.453);
                    Ccal_per_day = (66 + 13.7 * Weight + 5 * Height - 6.76 * Age);
                }
                else
                {
                    //женщина
                    Ideal_weight = ((Height * 3.5 / 2.54 - 108) * 0.453);
                    Ccal_per_day = (655 + 9.6 * Weight + 1.8 * Height - 4.7 * Age);
                }
                Ideal_weight = Math.Round(Ideal_weight, 2);
                Ccal_per_day = Math.Round(Ccal_per_day, 2);
                textBox2.Text = Ideal_weight.ToString();
                textBox6.Text = Ccal_per_day.ToString();
                DateTime dt = DateTime.Now;
                string curDate = dt.ToShortDateString();
                User ss = new User { Age = Age, Ccal_per_day = Ccal_per_day, Gender = comboBox1.Text, Height = Height, Ideal_weight = Ideal_weight, Weight = Weight, Date = curDate, Step = Step, Mark = Result };
                //var mass = new List<User>();
                //mass.Add(ss);
                //Properties.Settings.Default.History = JsonConvert.SerializeObject(History);
                //Properties.Settings.Default.Save();
                string History_JSON = Properties.Settings.Default.History;
                var Histories = JsonConvert.DeserializeObject<List<User>>(History_JSON);
                int index = Histories.FindIndex((k) => k.Date == curDate);
                if ( index == -1 )
                {
                    Histories.Add(ss);
                }
                else
                {
                    Histories[index] = ss;
                }
                Properties.Settings.Default.History = JsonConvert.SerializeObject(Histories);
                Properties.Settings.Default.Save();
            }
            catch(FormatException)
            {
                MessageBox.Show("Данные заполнены некорректно!", "Ошибка");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы:\n\nСтудент Тульского Государственного Педагогического Университета\nФакультета математики, физики и информатики\nГруппы 4В (120861)\nИванов Олег", "Об авторе");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 History = new Form2();
            History.ShowDialog();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Human Gender { get; set; }

    }
    public enum Human
    {
        male,
        female
    }
    public class User
    {
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Age { get; set; }
        public double Ideal_weight { get; set; }
        public double Ccal_per_day { get; set; }
        public string Date { get; set; }
        public int Step { get; set; }
        public string Mark { get; set; }
    }
}
