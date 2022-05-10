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
    public partial class AnalyzeForm : Form
    {
        private readonly List<AnalyzeResult> _analyzeResults;
        public AnalyzeForm(List<AnalyzeResult> analyzeResults)
        {
            _analyzeResults = analyzeResults;

            InitializeComponent();
            InitComboBox(analyzeResults);
        }

        private void InitComboBox(List<AnalyzeResult> analyzeResults)
        {
            UserComboBox.DisplayMember = nameof(AnalyzeResult.ActivityInfo.Name);
            UserComboBox.ValueMember = nameof(AnalyzeResult.ActivityInfo.Id);
            UserComboBox.DataSource = analyzeResults.Select(a => a.ActivityInfo).ToList();
        }

        private void FillData()
        {
            var id = (Guid)UserComboBox.SelectedValue;
            var analyzeResult = _analyzeResults.First(a => a.ActivityInfo.Id == id);

            UserName.Text = analyzeResult.ActivityInfo.Name;
            Age.Text = analyzeResult.ActivityInfo.Age.ToString("N0");
            UserHeight.Text = analyzeResult.ActivityInfo.Height.ToString("N2");
            Gender.Text = analyzeResult.ActivityInfo.GetGenderText();
            Goal.Text = analyzeResult.ActivityInfo.GetGoalText();
            Recommendations.Text = analyzeResult.Recommendations;
            Weight.Text = analyzeResult.ActivityInfo.Weight.ToString("N2");
            IdealWeight.Text = analyzeResult.IdealWeight.ToString("N1");
            
            AverageSteps.Text = analyzeResult.AverageSteps.ToString("N0");
            MaxSteps.Text = analyzeResult.MaxSteps.ToString("N0");
            MinSteps.Text = analyzeResult.MinSteps.ToString("N0");
            TotalSteps.Text = analyzeResult.TotalSteps.ToString("N0");

            AverageKcal.Text = analyzeResult.AverageKcal.ToString("N2");
            MaxKcal.Text = analyzeResult.MaxKcal.ToString("N2");
            MinKcal.Text = analyzeResult.MinKcal.ToString("N2");
            TotalKcal.Text = analyzeResult.TotalKcal.ToString("N2");
            
            MarkActivity.Text = analyzeResult.MarkActivity.Label;
            KkalPerDay.Text = analyzeResult.KkalPerDay.ToString("N0");
            PercentageOfIdealWeight.Text = $"({analyzeResult.PercentageOfIdealWeight.ToString("P0")} от идеального)";

            FillPie(analyzeResult.StepsByStatus);
        }

        private void FillPie(Dictionary<AnalyzeStepsResult, int> stepsByStatus)
        {
            ActivityPie.Series.Clear();

            var s = ActivityPie.Series.Add("s1");
            s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in stepsByStatus)
            {
                var dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, item.Value);
                dp.LegendText = item.Key.Label;

                s.Points.Add(dp);
            }
        }

        private void UserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
