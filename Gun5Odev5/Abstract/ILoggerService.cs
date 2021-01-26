using Gun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5.Abstract
{
    interface ILoggerService
    {
        public void Log(Sales sale);
        public void PrintLogs();
       
    }
}
