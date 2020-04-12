using CSVToJSON.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace CSVToJSON.Services
{
    public class FileProcessor : IFileProcessorService
    {
        public List<RateOverride> ParseDataFile(string dataFile)
        {
            var modelData = File.ReadAllLines(dataFile)
                .Skip(1)
                .Select(x => x.Split(','))
                .Select(dataRow => new RateOverride
                {
                    ClientId = Int32.Parse(dataRow[0]),
                    OrgUid = Int64.Parse(dataRow[1]),
                    LineItemCode = dataRow[2],
                    Rate = decimal.Parse(dataRow[3])
                }).ToList();

            if(modelData.Any())
            {
                return modelData;
            }
            else
            {
                return null;
            }
        }

        public string ConvertToJSON(List<RateOverride> modelList)
        {
            return JsonConvert.SerializeObject(modelList);
        }
    }
}
