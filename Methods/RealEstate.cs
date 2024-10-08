using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Methods
{
    public class RealEstate
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }
        public int CalculatePricePerFoot()=>Price/SquareFootage;
    }
}