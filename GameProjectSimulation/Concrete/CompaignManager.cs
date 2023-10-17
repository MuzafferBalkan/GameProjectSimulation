using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Concrete
{
    public class CompaignManager : ICompaignService
    {
        public void Add(Compaign compaign)
        {
            Console.WriteLine(compaign.CompaignName + " başarıyla eklendi.");
        }

        public void Delete(Compaign compaign)
        {
            Console.WriteLine(compaign.CompaignName +" başarıyla silindi.");
        }

        public void Show(Compaign compaign)
        {
            Console.WriteLine(compaign.CompaignName+" Kaçırma! bu indirim sayesinde istediğin oyun %"+compaign.DiscountRate+" daha ucuz");
        }

        public void Update(Compaign compaign)
        {
            Console.WriteLine(compaign.CompaignName + " başarıyla güncellendi.");
        }
    }
}
