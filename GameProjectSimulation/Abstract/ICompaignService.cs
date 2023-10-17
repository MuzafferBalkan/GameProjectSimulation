using GameProjectSimulation.Entities;
using GameProjectSimulation.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Abstract
{
    public interface ICompaignService
    {
        void Show(Compaign compaign);
        void Add(Compaign compaign);
        void Delete(Compaign compaign);
        void Update(Compaign compaign);
    }
}
