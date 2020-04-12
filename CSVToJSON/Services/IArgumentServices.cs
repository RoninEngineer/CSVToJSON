using System;
using System.Collections.Generic;
using System.Text;

namespace CSVToJSON.Services
{
    public interface IArgumentServices
    {
        string GetDataFileFromArguments(string[] arguments);
    }
}
