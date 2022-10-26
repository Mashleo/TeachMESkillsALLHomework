using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace WebAPI.Models
{
    public static class WorkWithFile
    {
       
        
        public static void Add(List<Person> person)
        {
            FileStream stream = File.Open("data", FileMode.OpenOrCreate);

            JsonSerializer js = new JsonSerializer();

            StreamWriter strWrit = new StreamWriter(stream);

            js.Serialize(strWrit, person);

            strWrit.Close();
            stream.Close();
        }
        public static List<Person> Get()
        {

            FileStream stream = File.Open("data", FileMode.OpenOrCreate);

            JsonSerializer js = new JsonSerializer();

            StreamReader strRead = new StreamReader(stream);


            var person = (List<Person>)js.Deserialize(strRead, typeof(List<Person>));


            strRead.Close();
            stream.Close();

            return person;
        }


    }
}
