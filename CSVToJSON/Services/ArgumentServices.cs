using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVToJSON.Services
{
    public class ArgumentServices : IArgumentServices
    {

        public string GetDataFileFromArguments(string[] arguments)
        {
            if (arguments.ElementAtOrDefault(0) != null)
            {
                if (ValidateDataFileExists(arguments[0]))
                {
                    return arguments[0];
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private bool ValidateDataFileExists(string dataFile)
        {
            return File.Exists(dataFile);
        }
    }
}
