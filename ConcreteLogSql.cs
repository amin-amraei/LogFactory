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
    internal class ConcreteLogSql : ILogger
    {
        public string LogOperation(LogOptions LogOptions)
        {
            
            var columnOptions = new ColumnOptions
            {
                AdditionalColumns = new Collection<SqlColumn>
                {
                    new SqlColumn("UserName", SqlDbType.NVarChar)
                }
            };
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.MSSqlServer(
                connectionString: LogOptions.Connectionstring,//configuration.GetConnectionString("SamaLogConnection"),
                tableName: "TbLogger",
                autoCreateSqlTable: true,
                columnOptions: columnOptions,
                schemaName: "dbo").CreateLogger();

            return "{Result of ConcreteLogSql}";
        }
    }
}
