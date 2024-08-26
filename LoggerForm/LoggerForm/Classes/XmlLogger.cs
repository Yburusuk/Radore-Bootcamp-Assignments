using LoggerForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerForm.Classes
{
    public class XmlLogger : ILogger
    {
        public string log(string message)
        {
            string response = "Durum: " + message + " Xml'e kaydedildi.";

            return response;
        }
    }
}
