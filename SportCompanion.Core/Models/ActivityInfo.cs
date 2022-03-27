using SportCompanion.Core.Models.Enums;
using System;
using System.Collections.Generic;

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
        public List<StepInfo> Steps { get; set; }

        public string GetGenderText()
        {
            return Gender == Human.Male ? "Мужчина" : "Женщина";
        }
    }
}
