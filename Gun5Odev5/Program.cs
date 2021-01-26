using Gun5Odev5.Abstract;
using Gun5Odev5.Concrete;
using Gun5Odev5.Entities;
using System;

namespace Gun5Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidateService eDevletValidation = new ValidationService();
            ILoggerService loggerService = new LoggerService();
            PlayerManager playerManager = new PlayerManager();
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();


            Player kutay = new Player() { Id = 0, FirstName = "Kutay", LastName = "Yıldırım", NationalityId = "00000000000" };
            playerManager.Add(kutay);

            Game gta = new Game() { Id = 0, Name = " Grand Theft Auto", Type = "Action,RPG", Price = 200 };
            gameManager.Add(gta);

            Game cod4 = new Game() { Id = 0, Name = " Call of Duty 4", Type = "Action, Shooter", Price = 250 };
            gameManager.Add(cod4);

            Game formula12020 = new Game() { Id = 0, Name = " Formula 1 2020", Type = "Racing, Simulator", Price = 150 };
            gameManager.Add(formula12020);

            Campaign blackFriday = new Campaign() { Id = 0, Name = "Black Friday", DiscountRate = 20 };
            campaignManager.Add(blackFriday);

            kutay.Buy(gta, blackFriday, loggerService);
            kutay.Buy(cod4, blackFriday, loggerService);
            kutay.Buy(formula12020, blackFriday, loggerService);

            loggerService.PrintLogs(); // to see all logs 



        }
    }
}
