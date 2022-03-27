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
    }
}
