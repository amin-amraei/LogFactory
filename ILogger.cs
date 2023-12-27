using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFactory
{
    public interface ILogger
    {
        string LogOperation(LogOptions logOptions);
    }
}
