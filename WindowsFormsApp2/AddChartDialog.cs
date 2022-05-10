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
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class AddChartDialog : Form
    {
        public ActivityInfo DialogResultData { get; set; }

        public AddChartDialog()
        {
            InitializeComponent();
            InitComboBoxes();
        }

        private void InitComboBoxes()
        {
            InitGenderComboBox();
            InitGoalComboBox();
        }

        private void InitGenderComboBox()
        {
            List<GenderSelector> people = new List<GenderSelector>
            {
                new GenderSelector { Gender = Human.Male, Name = "Мужчина" },
                new GenderSelector { Gender = Human.Female, Name = "Женщина" },
            };

            GenderComboBox.DataSource = people;
            GenderComboBox.DisplayMember = nameof(GenderSelector.Name);
            GenderComboBox.ValueMember = nameof(GenderSelector.Gender);
        }

        private void InitGoalComboBox()
        {
            List<GoalSelector> people = new List<GoalSelector>
            {
                new GoalSelector { Goal = Goal.Lose, Name = "Похудеть" },
                new GoalSelector { Goal = Goal.Keep, Name = "Поддерживать вес" },
            };

            GoalComboBox.DataSource = people;
            GoalComboBox.DisplayMember = nameof(GoalSelector.Name);
            GoalComboBox.ValueMember = nameof(GoalSelector.Goal);
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
                var goal = GetGoal();

                this.DialogResultData = new ActivityInfo
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Age = age,
                    Height = height,
                    Weight = weight,
                    Color = color,
                    Gender = gender,
                    Goal = goal
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Goal GetGoal()
        {
            var item = GoalComboBox.SelectedItem;
            if (item == default)
            {
                throw new ApplicationException("Не указана цель");
            }

            var goalSelector = (GoalSelector)item;

            return goalSelector.Goal;
        }

        private Human GetGender()
        {
            var item = GenderComboBox.SelectedItem;
            if (item == default)
            {
                throw new ApplicationException("Не указан пол");
            }

            var genderSelector = (GenderSelector)item;

            return genderSelector.Gender;
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
