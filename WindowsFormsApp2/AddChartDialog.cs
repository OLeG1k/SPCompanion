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
using WindowsFormsApp2.Helpers;

namespace WindowsFormsApp2
{
    public partial class AddChartDialog : Form
    {
        public ActivityInfo DialogResultData { get; set; }

        public AddChartDialog()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            List<Person> people = new List<Person>
            {
                new Person { Gender = Human.Male, Name = "Мужчина" },
                new Person { Gender = Human.Female, Name = "Женщина" },
            };

            GenderComboBox.DataSource = people;
            GenderComboBox.DisplayMember = nameof(Person.Name);
            GenderComboBox.ValueMember = nameof(Person.Gender);
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ChartPictureBox.BackColor = colorDialog.Color;
            }
        }

        private void AddChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                var name = GetName();
                var age = GetAge();
                var height = GetHeight();
                var weight = GetWeight();
                var color = GetColor();
                var gender = GetGender();

                DialogResultData = new ActivityInfo
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Age = age,
                    Height = height,
                    Weight = weight,
                    Color = color,
                    Gender = gender
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Human GetGender()
        {
            var item = GenderComboBox.SelectedItem;
            if (item == default)
            {
                throw new ApplicationException("Не указан пол");
            }

            var person = (Person)item;

            return person.Gender;
        }

        private SportCompanion.Core.Models.Color GetColor()
        {
            var color = ChartPictureBox.BackColor;

            var result = Helpers.ColorConverter.FromDrawingColor(color);

            return result;
        }

        private int GetAge()
        {
            var ageStr = AgeTextBox.Text;

            if (string.IsNullOrEmpty(ageStr))
            {
                throw new ApplicationException("Не указан возвраст");
            }

            if (!int.TryParse(ageStr, out var age) || age < 1)
            {
                throw new ApplicationException("Возвраст указан в неверном формате");
            }

            return age;
        }

        private double GetWeight()
        {
            var weightStr = WeightTextBox.Text;

            if (string.IsNullOrEmpty(weightStr))
            {
                throw new ApplicationException("Не указан вес");
            }

            if (!double.TryParse(weightStr, out var weight) || weight < 1)
            {
                throw new ApplicationException("Вес указан в неверном формате");
            }

            return weight;
        }

        private double GetHeight()
        {
            var heightStr = HeightTextBox.Text;

            if (string.IsNullOrEmpty(heightStr))
            {
                throw new ApplicationException("Не указан рост");
            }

            if (!double.TryParse(heightStr, out var height) || height < 1)
            {
                throw new ApplicationException("Рост указан в неверном формате");
            }

            return height;
        }

        private string GetName()
        {
            var name = NameTextBox.Text;
            return name;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }    
}
