using Gun5Odev5.Abstract;
using Gun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5.Concrete
{
    class LoggerService : ILoggerService
    {
        List<string> logs = new List<string>();     //Sales will be stored in that list.

        public void Log(Sales sale)
        {
            logs.Add("Game:"+ sale.GameName +", Pname: " + sale.PlayerName + ", Campaign Discount: " + sale.CampaignDiscount + ", Cost: " + sale.TotalCost);
            Console.WriteLine("The game " + sale.GameName + " bought by " + sale.PlayerName + " and the cost is " + sale.TotalCost);
            Console.WriteLine("Process was logged in file.");
        }

        public void PrintLogs()
        {
            Console.WriteLine("------------ Logs ------------\n");
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
            Console.WriteLine("------------ End of Logs ------------\n");
        }
    }
}
