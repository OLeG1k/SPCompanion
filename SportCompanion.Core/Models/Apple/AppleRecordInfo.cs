﻿using System;

namespace SportCompanion.Core.Models.Apple
{
    public class AppleRecordInfo
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CalculatedDate
        {
            get
            {
                DateTime date;

                var startDate = StartDate.Date;
                var endDate = EndDate.Date;
                if (startDate == EndDate.Date)
                {
                    date = startDate;
                }
                else
                {
                    var r1 = endDate - StartDate;
                    var r2 = EndDate - endDate;

                    if (r1 >= r2)
                    {
                        date = startDate;
                    }
                    else
                    {
                        date = endDate;
                    }
                }

                return date;
            }
        }
    }
}
