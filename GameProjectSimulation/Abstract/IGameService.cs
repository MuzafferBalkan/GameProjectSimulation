using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void Show(Gamer gamer,Game game, Compaign compaign);
        void Sell(Gamer gamer,Game game);
    }
}
