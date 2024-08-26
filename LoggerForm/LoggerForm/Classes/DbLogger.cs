using LoggerForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForm.Classes
{
    public class DbLogger : ILogger
    {
        public string log(string message)
        {
            string response = "Durum: " + message + " Db'ye kaydedildi.";

            return response;
        }
    }
}
