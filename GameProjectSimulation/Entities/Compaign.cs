using GameProjectSimulation.Concrete;
using GameProjectSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectSimulation.Entities
{
    public class Compaign
    {
        public int CompaignId { get; set; }
        public string CompaignName { get; set; }
        public double DiscountRate { get; set; }
    }
}
