using CSVToJSON.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSVToJSON.Services
{
    public interface IFileProcessorService
    {
        List<RateOverride> ParseDataFile(string dataFile);
        string ConvertToJSON(List<RateOverride> modelList);
    }
}
