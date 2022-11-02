using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2510.Models
{
    public static class WorkWithCars
    {
        public static List<Cars> GetCompletedListCars()
        {
            List<Cars> listCars = new List<Cars>();

            var car = new Cars("Lambo", "Supercar", 10, "Gas");
            var car2 = new Cars("VW", "Bus", 5, "Diesel");
            var car3 = new Cars("Audi", "Sedan", 6, "Diesel");
            var car4 = new Cars("Porsche", "SUV", 8, "Gas");
            
            listCars.Add(car);
            listCars.Add(car2);
            listCars.Add(car3);
            listCars.Add(car4);
            
            return listCars;
        }
        public static void SerializeListToJSON(List<Cars> cars)
        {
            
            FileStream stream = File.Open("Table.json", FileMode.OpenOrCreate);
            
            StreamWriter streamWriter = new StreamWriter(stream);
            
            JsonSerializer js = new JsonSerializer();
            
            js.Serialize(streamWriter,cars);
            
            streamWriter.Close();
            stream.Close();

        }

    }
}
