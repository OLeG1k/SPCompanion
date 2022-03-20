using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SportCompanion.Core
{
    public class DataProcessor
    {
        private const string APPLE_MAIN_NODE = "HealthData";
        private const string APPLE_RECORD_NODE = "Record";
        private const string APPLE_STEP_IDENTIFIER = "HKQuantityTypeIdentifierStepCount";

        public Dictionary<DateTime, int> Import(string path)
        {
            List<StepInfo> stepInfoList = ReadFile(path);
            var data = Prepare(stepInfoList);

            return data;
        }

        private List<StepInfo> ReadFile(string path)
        {
            var stepInfoList = new List<StepInfo>();
            var reader = XmlReader.Create(path, new XmlReaderSettings() { Async = true, DtdProcessing = DtdProcessing.Parse });
            using (reader)
            {
                if (reader.ReadToFollowing(APPLE_MAIN_NODE))
                {
                    var locale = reader.GetAttribute("locale");

                    CultureInfo culture;
                    try
                    {
                        culture = CultureInfo.GetCultureInfo(locale);
                    }
                    catch (CultureNotFoundException ex)
                    {
                        culture = CultureInfo.CurrentCulture;
                    }

                    while (reader.ReadToFollowing(APPLE_RECORD_NODE))
                    {
                        var type = reader.GetAttribute("type");
                        if (type == APPLE_STEP_IDENTIFIER)
                        {
                            var startDateAttr = reader.GetAttribute("startDate");
                            var endDateAttr = reader.GetAttribute("endDate");
                            var valueAttr = reader.GetAttribute("value");

                            if (DateTime.TryParse(startDateAttr, culture, DateTimeStyles.None, out var startDate)
                                && DateTime.TryParse(endDateAttr, culture, DateTimeStyles.None, out var endDate)
                                && int.TryParse(valueAttr, out var value))
                            {
                                var stepInfo = new StepInfo()
                                {
                                    StartDate = startDate,
                                    EndDate = endDate,
                                    Value = value
                                };

                                stepInfoList.Add(stepInfo);
                            }
                        }
                    }
                }
                else
                {
                    throw new ApplicationException($"Ошибка импорта. Отсутствует '{APPLE_MAIN_NODE}'.");
                }
            }

            return stepInfoList;
        }

        private Dictionary<DateTime, int> Prepare(List<StepInfo> stepInfoList)
        {
            Dictionary<DateTime, int> stepsByDate = stepInfoList.GroupBy(s => s.CalculatedDate)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Sum(z => z.Value));

            return stepsByDate;
        }
    }
}
