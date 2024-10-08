using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructor
{
    
    public class RealEstate
    {
        private string _name;
        private string _address;
        public RealEstate(string name, string address )
        {
            _name = name;
            _address = address;
            Console.WriteLine("A new object is created for "+ _name);
        }
        public string Name 
        { 
            get => _name; 
            set => _name=value; }
    }
}