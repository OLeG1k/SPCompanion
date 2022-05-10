using Newtonsoft.Json;
using SportCompanion.Core.Models;
using SportCompanion.Core.Models.Apple;
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
        private const string APPLE_ENERGY_IDENTIFIER = "HKQuantityTypeIdentifierBasalEnergyBurned";

        public ImportResult Import(string path, DateTime? limit)
        {
            var readResult = ReadFile(path, limit);
            var data = Aggregate(readResult);

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

        private ReadAppleFileResult ReadFile(string path, DateTime? limit)
        {
            var result = new ReadAppleFileResult()
            {
                Steps = new List<AppleStepInfo>(),
                Energy = new List<AppleEnergyInfo>()
            };
            
            var reader = XmlReader.Create(path, new XmlReaderSettings() { Async = true, DtdProcessing = DtdProcessing.Parse });
            using (reader)
            {
                if (reader.ReadToFollowing(APPLE_MAIN_NODE))
                {
                    CultureInfo culture = GetCulture(reader);
                    while (reader.ReadToFollowing(APPLE_RECORD_NODE))
                    {
                        var stepInfo = ReadRecordStepNode(reader, culture, limit);
                        if (stepInfo != null)
                        {
                            result.Steps.Add(stepInfo);
                        }
                        else
                        {
                            var energyInfo = ReadRecordEnergyNode(reader, culture, limit);
                            if (energyInfo != null)
                            {
                                result.Energy.Add(energyInfo);
                            }
                        }
                    }
                }
                else
                {
                    throw new ApplicationException($"Ошибка импорта. Отсутствует '{APPLE_MAIN_NODE}'.");
                }
            }

            return result;
        }

        private AppleStepInfo ReadRecordStepNode(XmlReader reader, CultureInfo culture, DateTime? limit)
        {
            AppleStepInfo info = null;

            var type = reader.GetAttribute("type");
            if (type == APPLE_STEP_IDENTIFIER)
            {
                var startDateAttr = reader.GetAttribute("startDate");

                if (DateTime.TryParse(startDateAttr, culture, DateTimeStyles.None, out var startDate) && (!limit.HasValue || startDate >= limit.Value))
                {
                    var endDateAttr = reader.GetAttribute("endDate");
                    var valueAttr = reader.GetAttribute("value");

                    if (DateTime.TryParse(endDateAttr, culture, DateTimeStyles.None, out var endDate)
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
            }

            return info;
        }

        private AppleEnergyInfo ReadRecordEnergyNode(XmlReader reader, CultureInfo culture, DateTime? limit)
        {
            AppleEnergyInfo info = null;

            var type = reader.GetAttribute("type");
            if (type == APPLE_ENERGY_IDENTIFIER)
            {
                var startDateAttr = reader.GetAttribute("startDate");

                if (!DateTime.TryParse(startDateAttr, culture, DateTimeStyles.None, out var startDate) || startDate <= limit)
                {
                    return null;
                }

                var endDateAttr = reader.GetAttribute("endDate");
                var valueAttr = reader.GetAttribute("value");
                var unitAttr = reader.GetAttribute("unit") ?? string.Empty;

                if (unitAttr.Equals("kcal")
                    && DateTime.TryParse(endDateAttr, culture, DateTimeStyles.None, out var endDate)
                    && (double.TryParse(valueAttr,  NumberStyles.Any, culture, out var value)
                        || double.TryParse(valueAttr,  NumberStyles.Any, CultureInfo.InvariantCulture, out value))
                    )
                {
                    
                    info = new AppleEnergyInfo()
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

        private ImportResult Aggregate(ReadAppleFileResult readResult)
        {
            List<StepInfo> steps = readResult.Steps.GroupBy(s => s.CalculatedDate)
                .OrderBy(g => g.Key)
                .Select(g => new StepInfo { Date = g.Key, Value = g.Sum(z => z.Value) } )
                .ToList();

            List<EnergyInfo> energy = readResult.Energy.GroupBy(s => s.CalculatedDate)
                .OrderBy(g => g.Key)
                .Select(g => new EnergyInfo { Date = g.Key, Value = g.Sum(z => z.Value) } )
                .ToList();

            ImportResult result = new ImportResult()
            {
                Steps = new StepInfoCollection(steps),
                Energy = new EnergyInfoCollection(energy)
            };

            return result;
        }
    }
}
