using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;
using System;

namespace GameProjectSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 17, FirsName = "Muzaffer", LastName = "Balkan", BirthYear = 2002, IdentityNumber = "12345678910" });

            Gamer gamer2 = new Gamer();
            gamer2.Id = 914;
            gamer2.FirsName = "Berke";
            gamer2.LastName = "Kılıç";

            Compaign compaign1 = new Compaign();
            compaign1.CompaignId = 1;
            compaign1.CompaignName = "Yaz İndirimi";
            compaign1.DiscountRate = 25;

            Compaign compaign2 = new Compaign();
            compaign2.CompaignId = 2;
            compaign2.CompaignName = "Süper Kasım İndirimi";
            compaign2.DiscountRate = 40;

            CompaignManager compaignManager = new CompaignManager();
            compaignManager.Show(compaign1);
            compaignManager.Add(compaign2);
            compaignManager.Delete(compaign1);
            compaignManager.Update(compaign2);


            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Clash of Clans";
            game1.GamePrice = 100;

            Game game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "Pokemon red";
            game2.GamePrice = 120;

            GameManager gameManager = new GameManager();
            gameManager.Add(game2);
            gameManager.Delete(game1);
            gameManager.Update(game1);
            gameManager.Show(gamer2,game2,compaign2);
            gameManager.Sell(gamer2, game2);





        }
    }
}
