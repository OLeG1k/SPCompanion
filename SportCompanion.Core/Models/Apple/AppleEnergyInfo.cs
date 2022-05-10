namespace SportCompanion.Core.Models.Apple
{
    public class AppleEnergyInfo : AppleRecordInfo
    {
        public double Value { get; set; }

        public static AppleEnergyInfo ConvertFrom(AppleRecordInfo appleRecordInfo)
        {
            return new AppleEnergyInfo
            {
                EndDate = appleRecordInfo.EndDate,
                StartDate = appleRecordInfo.StartDate
            };
        }
    }
}
