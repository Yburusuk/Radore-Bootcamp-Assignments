using LoggerForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForm.Classes
{
    public class LoggerService
    {
        private readonly ILogger logger;

        public LoggerService(ILogger logger)
        {
            this.logger = logger;
        }

        public string Log(string message)
        {
            string response = logger.log(message);
            
            return response;
        }
    }
}
