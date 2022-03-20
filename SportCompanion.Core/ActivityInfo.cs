using SportCompanion.Core.Models.Enums;
using System.Collections.Generic;

namespace SportCompanion.Core
{
    public class ActivityInfo
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Human Gender { get; set; }
        public List<StepInfo> Steps { get; set; }
    }
}
