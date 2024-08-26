using LoggerForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForm.Classes
{
    public class LoggerFactory
    {
        public ILogger createLogger(string className)
        {
            var newInstance = Assembly.GetAssembly(typeof(ILogger)).CreateInstance("LoggerForm.Classes." + className);
            
            return (ILogger)newInstance;

        }
    }
}
