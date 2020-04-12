using CSVToJSON.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CSVToJSON.Configuration
{
    public class ContainerConfiguration
    {
        public static ServiceProvider Configure()
        {
            return new ServiceCollection()
                .AddSingleton<IFileProcessorService, FileProcessor>()
                .AddSingleton<IArgumentServices, ArgumentServices>()
                .AddSingleton<IClipboardService, ClipboardService>()
                .BuildServiceProvider();
        }
    }
}
