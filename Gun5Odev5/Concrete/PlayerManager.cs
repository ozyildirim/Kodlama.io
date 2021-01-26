using Gun5Odev5.Abstract;
using Gun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5.Concrete
{
    class PlayerManager
    {
        List<Player> playerList = new List<Player>();
        public void Add(Player player)
        {
            ValidationService validationService = new ValidationService();
            if (validationService.Validate(player))
            {
                playerList.Add(player);
                Console.WriteLine("Player " + player.FirstName + "added.");
            }else
            {
                Console.WriteLine("Problem was occured, player couldn't be created.");
            }
        }

        public void Delete(Player player)
        {
            playerList.Remove(player);
            Console.WriteLine("Player removed from database.");
        }
        public void Update()
        {
            Console.WriteLine("Player updated.");
        }

        

    }
}
