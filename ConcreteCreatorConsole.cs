﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogFactory
{
    public class ConcreteCreatorConsole : Creator
    {
        public override ILogger FactoryMethod()
        {
            return new ConcreteLogConsole();
        }
    }
}
