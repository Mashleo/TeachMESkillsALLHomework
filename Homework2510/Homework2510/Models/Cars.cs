using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2510.Models
{
    public class Cars
    {
        public Cars(string _brand,string _type, int _cylinder, string _fuel)
        {
            Brand = _brand;
            TypeBody = _type;
            Engine = new Engine
            {
                Cylinder = _cylinder,
                Fuel = _fuel
            };         

        }
        public string Brand { get; set; }
        public string TypeBody { get; set; }
        public Engine Engine { get; set; }
    }

    public class Engine
    {
        public int Cylinder  { get; set; }
        public  string Fuel  { get; set; }

    }
}
