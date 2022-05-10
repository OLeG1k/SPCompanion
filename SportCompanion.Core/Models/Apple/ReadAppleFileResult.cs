using System.Collections.Generic;

namespace SportCompanion.Core.Models.Apple
{
    public class ReadAppleFileResult
    {
        public List<AppleStepInfo> Steps { get; set; }
        public List<AppleEnergyInfo> Energy { get; set; }
    }
}
