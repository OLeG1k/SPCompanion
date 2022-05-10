using SportCompanion.Core.Models;
using SportCompanion.Core.Models.Enums;
using System;

namespace SportCompanion.Core
{
    public class SuggestProcessor
    {
        public string GetRecommendations(Goal goal, AnalyzeStepsResult.ActivityStatus status)
        {
            string recommendations;
            switch (goal)
            {
                case Goal.Lose:
                    recommendations = GetLoseRecommendations(status);
                    break;
                case Goal.Keep:
                    recommendations = GetKeepRecommendations(status);
                    break;
                default:
                    recommendations = string.Empty;
                    break;
            }

            return recommendations;
        }

        private string GetKeepRecommendations(AnalyzeStepsResult.ActivityStatus status)
        {
            string result = null;
            switch (status)
            {
                case AnalyzeStepsResult.ActivityStatus.Terrible:
                    result = @"Вам требуется больше двигательной активности. Для поддержания веса требуется:
разминка в течении 10-и минут (по 2.5 мин. на упражнение): Вращения головы и шеи, разминка рук, вращение тазобедренным суставом. Далее наклоны, махи ногами, скручивания, приседания, выпады, отжимания. Каждое упражнение по 10 раз/4 подхода. Завершаем планкой на 1 минуту 3 подхода. ";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Bad:
                    result = @"У Вас недостаточная двигательная активность. Для поддержания веса требуется:
разминка в течении 8-и минут (по 2 мин. на упражнение): Вращения головы и шеи, разминка рук, вращение тазобедренным суставом. Далее наклоны, махи ногами, скручивания, приседания, отжимания. Каждое упражнение по 10 раз/4 подхода. ";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Normal:
                    result = @"У Вас подходящая двигательная активность для поддержания веса.";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Good:
                    result = @"Двигательная активность превышает норму. Для поддержания веса рекомендуем снизить активность.";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Perfect:
                    result = @"Двигательная активность серьёзно превышает норму. Рекомендуем снизить активность для поддержания веса или больше кушать :)";
                    break;
                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }

        private string GetLoseRecommendations(AnalyzeStepsResult.ActivityStatus status)
        {
            string result = null;

            switch (status)
            {
                case AnalyzeStepsResult.ActivityStatus.Terrible:
                    result = @"Вам требуется больше двигательной активности. Рекомендация :
                        разминка в течении 10-и минут (по 2.5 мин. на упражнение): Вращения головы и шеи, разминка рук, вращение тазобедренным суставом. Далее наклоны, махи ногами, скручивания, приседания, выпады, отжимания. Каждое упражнение по 10 раз/4 подхода. Завершаем планкой на 1 минуту 3 подхода.";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Bad:
                    result = @"У Вас недостаточная двигательная активность.
Рекомендация :
разминка в течении 8-и минут (по 2 мин. на упражнение): Вращения головы и шеи, разминка рук, вращение тазобедренным суставом. Далее наклоны, махи ногами, скручивания, приседания, отжимания. Каждое упражнение по 10 раз/4 подхода.";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Normal:
                    result = @"У Вас нормальная двигательная активность. Для её улучшения требуется:
разминка в течении 4-ёх минут (по 1 мин. на упражнение): Вращения головы и шеи, разминка рук, вращение тазобедренным суставом. Далее наклоны, скручивания, приседания, отжимания. Каждое упражнение по 10 раз/3 подхода.";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Good:
                    result = @"У Вас хорошая двигательная активность. Рекомендаций к физической нагрузке нет.";
                    break;
                case AnalyzeStepsResult.ActivityStatus.Perfect:
                    result = @"У Вас прекрасная двигательная активность, дополнительная физическая нагрузка не требуется!";
                    break;
                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }
    }
}