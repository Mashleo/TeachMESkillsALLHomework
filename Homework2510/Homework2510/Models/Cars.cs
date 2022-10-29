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
            brand = _brand;
            typeBody = _type;
            engine = new Engine
            {
                cylinder = _cylinder,
                fuel = _fuel
            };
            

        }
        public string brand { get; set; }
        public string typeBody { get; set; }
        public Engine engine { get; set; }
    }
    public class Engine
    {
        public int cylinder  { get; set; }
        public  string fuel  { get; set; }

    }
}
