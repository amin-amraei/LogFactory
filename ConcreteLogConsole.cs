using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFactory
{
    public class ConcreteLogConsole : ILogger
    {
        public string LogOperation(LogOptions logOptions)
        {           
            return "{Result of ConcreteLogConsole}";
        }
    }
}
