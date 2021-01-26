using Gun5Odev5.Abstract;
using Gun5Odev5.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5.Entities
{
    class Player
    {   
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalityId { get; set; }
        public List<Sales> PurchasedGames { get; set; }
        public void Buy(Game game, Campaign campaign, ILoggerService loggerService)
        {
            Sales newSale = new Sales();
            newSale.Id = 0;
            newSale.PlayerId = this.Id;
            newSale.PlayerName = this.FirstName + " " + this.LastName;
            newSale.GameId = game.Id;
            newSale.GameName = game.Name;
            newSale.CampaignDiscount = campaign.DiscountRate;
            newSale.TotalCost = game.Price - (game.Price * campaign.DiscountRate / 100);
            Console.WriteLine(campaign.Name + " was used");

            loggerService.Log(newSale);
            //PurchasedGames.Add(newSale);
        }
    }
}
