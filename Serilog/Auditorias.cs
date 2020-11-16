
using Microsoft.Extensions.Configuration;
using System;

namespace Serilog
{
    public class Auditorias
    {

        public void ConfigurarLogs() {


        var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

        var logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(configuration)
                        .CreateLogger();
        }
    }
}
