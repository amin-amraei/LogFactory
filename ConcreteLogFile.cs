using Serilog.Sinks.MSSqlServer;
using Serilog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFactory
{
    internal class ConcreteLogFile : ILogger
    {
        public string LogOperation(LogOptions logOptions)
        {

            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.File(
                path: logOptions.Path,//@"Serilogs\AppLog_.log",
                outputTemplate: "{Timestamp:HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 10)
                .CreateBootstrapLogger();
            return "{Result of ConcreteLogFile}";
        }
    }
}
