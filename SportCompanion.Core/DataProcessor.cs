using Newtonsoft.Json;
using SportCompanion.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

        public List<StepInfo> Import(string path)
        {
            List<AppleStepInfo> stepInfoList = ReadFile(path);
            var data = Aggregate(stepInfoList);

            return data;
        }

        public List<ActivityInfo> LoadData(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }

            try
            {
                var json = File.ReadAllText(path, Encoding.UTF8);
                return JsonConvert.DeserializeObject<List<ActivityInfo>>(json);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Во время загрузки данных произошла ошибка.", ex);
            }
        }

        public void SaveData(string path, List<ActivityInfo> activityInfos)
        {
            try
            {
                var json = JsonConvert.SerializeObject(activityInfos);
                using (var fs = System.IO.File.Create(path))
                {
                    byte[] info = new UTF8Encoding().GetBytes(json);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Не удалось сохранить файл", ex);
            }
        }

        private List<AppleStepInfo> ReadFile(string path)
        {
            var stepInfoList = new List<AppleStepInfo>();
            var reader = XmlReader.Create(path, new XmlReaderSettings() { Async = true, DtdProcessing = DtdProcessing.Parse });
            using (reader)
            {
                if (reader.ReadToFollowing(APPLE_MAIN_NODE))
                {
                    CultureInfo culture = GetCulture(reader);

                    while (reader.ReadToFollowing(APPLE_RECORD_NODE))
                    {
                        var stepInfo = ReadRecordNode(stepInfoList, reader, culture);

                        if (stepInfo != null)
                        {
                            stepInfoList.Add(stepInfo);
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

        private AppleStepInfo ReadRecordNode(List<AppleStepInfo> stepInfoList, XmlReader reader, CultureInfo culture)
        {
            AppleStepInfo info = null;

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
                    info = new AppleStepInfo()
                    {
                        StartDate = startDate,
                        EndDate = endDate,
                        Value = value
                    };
                }
            }

            return info;
        }

        private CultureInfo GetCulture(XmlReader reader)
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

            return culture;
        }

        private List<StepInfo> Aggregate(List<AppleStepInfo> stepInfoList)
        {
            List<StepInfo> steps = stepInfoList.GroupBy(s => s.CalculatedDate)
                .OrderBy(g => g.Key)
                .Select(g => new StepInfo { Date = g.Key, Value = g.Sum(z => z.Value) } )
                .ToList();

            return steps;
        }
    }
}
