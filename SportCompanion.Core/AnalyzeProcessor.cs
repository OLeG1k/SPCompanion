using SportCompanion.Core.Models;
using SportCompanion.Core.Models.Enums;
using System;
using System.Linq;

namespace SportCompanion.Core
{
    public class AnalyzeProcessor
    {
        public AnalyzeResult Analyze(ActivityInfo activityInfo)
        {
            var result = new AnalyzeResult
            { 
                ActivityInfo = activityInfo
            };

            result.TotalSteps = activityInfo.Steps.Sum(s => s.Value);
            result.MaxSteps = activityInfo.Steps.Max(s => s.Value);
            result.MinSteps = activityInfo.Steps.Min(s => s.Value);

            var averageSteps = activityInfo.Steps.Average(s => s.Value);
            result.AverageSteps = Convert.ToInt32(averageSteps);

            result.MarkActivity = AnalyzeSteps(result.AverageSteps);

            result.IdealWeight = CalculateIdealWeight(activityInfo);
            result.KkalPerDay = CalculateRecommendKkalPerDay(activityInfo);

            var percentageOfIdealWeight = activityInfo.Weight / result.IdealWeight;

            result.PercentageOfIdealWeight = percentageOfIdealWeight;

            result.StepsByStatus = activityInfo.Steps.Select(s => AnalyzeSteps(s.Value))
                .GroupBy(a => a.Status)
                .ToDictionary(g => g.First(), g => g.Count());

            return result;
        }

        public double CalculateIdealWeight(ActivityInfo activityInfo)
        {
            double idealWeight;
            double height = activityInfo.Height;

            if (activityInfo.Gender == Human.Male)
            {
                idealWeight = ((height * 4 / 2.54 - 128) * 0.453);
            }
            else
            {
                idealWeight = ((height * 3.5 / 2.54 - 108) * 0.453);
            }

            return idealWeight;
        }

        public double CalculateRecommendKkalPerDay(ActivityInfo activityInfo)
        {
            double kkalPerDay;
            double height = activityInfo.Height;
            double weight = activityInfo.Weight;
            double age = activityInfo.Age;

            if (activityInfo.Gender == Human.Male)
            {
                kkalPerDay = (66 + 13.7 * weight + 5 * height - 6.76 * age);
            }
            else
            {
                kkalPerDay = (655 + 9.6 * weight + 1.8 * height - 4.7 * age);
            }

            return kkalPerDay;
        }

        public AnalyzeStepsResult AnalyzeSteps(int stepsCount)
        {
            AnalyzeStepsResult result = new AnalyzeStepsResult();

            if (stepsCount < 2500)
            {
                result.Status = AnalyzeStepsResult.ActivityStatus.Terrible;
            }
            else if (stepsCount < 5000)
            {
                result.Status = AnalyzeStepsResult.ActivityStatus.Bad;
            }
            else if (stepsCount < 7500)
            {
                result.Status = AnalyzeStepsResult.ActivityStatus.Normal;
            }
            else if (stepsCount < 10000)
            {
                result.Status = AnalyzeStepsResult.ActivityStatus.Good;
            }
            else
            {
                result.Status = AnalyzeStepsResult.ActivityStatus.Perfect;
            }

            return result;
        }
    }
}
