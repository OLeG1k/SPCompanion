using System;

namespace SportCompanion.Core.Models
{
    public class AnalyzeStepsResult
    {
        private string _label;
        private ActivityStatus _status;


        public ActivityStatus Status
        {
            get => _status;
            set
            {
                _status = value;
                _label = GetLabel();
            }
        }

        public string Label => _label;

        private string GetLabel()
        {
            string result;
            switch (Status)
            {
                case ActivityStatus.Terrible:
                    result = "Очень плохая";
                    break;
                case ActivityStatus.Bad:
                    result = "Плохая";
                    break;
                case ActivityStatus.Normal:
                    result = "Нормальная";
                    break;
                case ActivityStatus.Good:
                    result = "Отличная";
                    break;
                case ActivityStatus.Perfect:
                    result = "Потрясающая!";
                    break;
                default:
                    throw new NotImplementedException();
            }

            return result;
        }



        public enum ActivityStatus
        {
            Terrible,
            Bad,
            Normal,
            Good,
            Perfect
        }
    }
}
