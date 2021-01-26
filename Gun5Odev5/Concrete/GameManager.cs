using Gun5Odev5.Abstract;
using Gun5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5Odev5.Concrete
{
    class GameManager
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("Game '" + game.Name + "' is added.");
        }

        public void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
