using CSVToJSON.Configuration;
using CSVToJSON.Services;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CSVToJSON
{
    public class CSVToJSON
    {
        static int Main(string[] args) // static with a void (or int) return type
        {
            if (args == null)
            {
                return 404;
            }
            else
            {
                try
                {
                    var serviceProvider = ContainerConfiguration.Configure();
                    var dataFile = serviceProvider.GetService<IArgumentServices>().GetDataFileFromArguments(args);
                    if (!String.IsNullOrEmpty(dataFile))
                    {
                        var parsedData = serviceProvider.GetService<IFileProcessorService>().ParseDataFile(dataFile);
                        if (parsedData.Any())
                        {
                            var jsonData = serviceProvider.GetService<IFileProcessorService>().ConvertToJSON(parsedData);
                            serviceProvider.GetService<IClipboardService>().SetText(jsonData);
                        }
                        else
                        {
                            return 400;
                        }
                    }
                    else
                    {
                        return 404;
                    }
                    return 200;
                }
                catch (Exception)
                {
                    return 500; ;
                }
            }
        }
    }
}
