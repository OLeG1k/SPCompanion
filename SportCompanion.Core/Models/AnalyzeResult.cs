using System.Collections.Generic;

namespace SportCompanion.Core.Models
{
    public class AnalyzeResult
    {
        public ActivityInfo ActivityInfo { get; set; }

        public double IdealWeight { get; set; }
        public int MinSteps { get; set; }
        public int MaxSteps { get; set; }
        public int AverageSteps { get; set; }
        public double KkalPerDay { get; set; }
        public double PercentageOfIdealWeight { get; set; }
        public AnalyzeStepsResult MarkActivity { get; set; }
        public Dictionary<AnalyzeStepsResult, int> StepsByStatus { get; set; }
        public int TotalSteps { get; set; }
        public string Recommendations { get; set; }
        public double MinKcal { get; set; }
        public double MaxKcal { get; set; }
        public double AverageKcal { get; set; }
        public double TotalKcal { get; set; }
    }
}
