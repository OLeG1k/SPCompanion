using SportCompanion.Core.Models.Enums;
using System;

namespace SportCompanion.Core.Models
{
    public class ActivityInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Human Gender { get; set; }
        public Goal Goal { get; set; }
        public StepInfoCollection Steps { get; set; }
        public EnergyInfoCollection Energy { get; set; }

        public string GetGenderText()
        {
            return Gender == Human.Male ? "Мужчина" : "Женщина";
        }

        public string GetGoalText()
        {
            string text;
            switch (Goal)
            {
                case Goal.Lose:
                    text = "Похудеть";
                    break;
                case Goal.Keep:
                    text = "Поддержать вес";
                    break;
                default:
                    text = "<Неизвестна>";
                    break;
            }

            return text;
        }
    }
}
