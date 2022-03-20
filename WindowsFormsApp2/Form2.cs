using Newtonsoft.Json;
using SportCompanion.Core.Models;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string dd = Properties.Settings.Default.History;
            History = JsonConvert.DeserializeObject<List<User>>(dd);
            foreach (User item in History)
            {
                string asd = new StringBuilder ( $"Дата - {item.Date} \r\n Пол - {item.Gender}   Возраст - {item.Age} лет   Рост - {item.Height} см   Вес - {item.Weight} кг   Идеальный вес - {item.Ideal_weight} кг   Норма ккал в день - {item.Ccal_per_day} ккал   Шаги - {item.Step}   \n Оценка физической активности - \"{item.Mark}\"\r\n \r\n").ToString();
                textBox1.Text = textBox1.Text + asd;
            } 
        }
        public List<User> History;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Graphic = new Form3(History);
            Graphic.ShowDialog();
        }
    }
}
