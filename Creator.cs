using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFactory
{
    public abstract class Creator
    {        
        public abstract ILogger FactoryMethod();
        public string LogOperation(LogOptions LogOptions)
        {
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.LogOperation(LogOptions);

            return result;
        }
    }
}
