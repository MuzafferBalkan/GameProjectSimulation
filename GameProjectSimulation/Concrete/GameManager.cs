using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu başarıyla eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu başarıyla silindi.");
        }

        public void Sell(Gamer gamer,Game game)
        {
            Console.WriteLine("Tebrikler "+ gamer.FirsName);
            Console.WriteLine(game.GameName+" Satın alımı başarılı.");
        }

        public void Show(Gamer gamer,Game game, Compaign compaign)
        {
            Console.WriteLine(gamer.FirsName+" senin için özel fırsatlarımız var.");
            Console.WriteLine(game.GameName + ": " + game.GamePrice+"TL");
            Console.WriteLine(compaign.CompaignName + " ile yeni fiyatı: " +(game.GamePrice-(game.GamePrice*compaign.DiscountRate/100)+"TL"));
            Console.WriteLine("SATIN AL");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+" oyunu başarıyla güncellendi.");        }
    }
}
