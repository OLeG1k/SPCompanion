namespace SportCompanion.Core.Models.Apple
{
    public class AppleStepInfo : AppleRecordInfo
    {
        public int Value { get; set; }
        public static AppleStepInfo ConvertFrom(AppleRecordInfo appleRecordInfo)
        {
            return new AppleStepInfo
            {
                EndDate = appleRecordInfo.EndDate,
                StartDate = appleRecordInfo.StartDate
            };
        }
    }
}
