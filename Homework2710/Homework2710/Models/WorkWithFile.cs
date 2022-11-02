using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2710.Models
{
    public static class WorkWithFile
    {


        public static void Add(List<Person> person)
        {
            FileStream stream = File.Open("appsettings.Person.json", FileMode.OpenOrCreate);

            JsonSerializer js = new JsonSerializer();

            StreamWriter strWrit = new StreamWriter(stream);

            js.Serialize(strWrit, person);

            strWrit.Close();
            stream.Close();
        }
        public static List<Person> Get()
        {

            FileStream stream = File.Open("appsettings.Person.json", FileMode.OpenOrCreate);

            JsonSerializer js = new JsonSerializer();

            StreamReader strRead = new StreamReader(stream);


            var person = (List<Person>)js.Deserialize(strRead, typeof(List<Person>));


            strRead.Close();
            stream.Close();

            return person;
        }
        public static Person Getid(int id)
        {

            FileStream stream = File.Open("appsettings.Person.json", FileMode.OpenOrCreate);

            JsonSerializer js = new JsonSerializer();

            StreamReader strRead = new StreamReader(stream);


            var person = (List<Person>)js.Deserialize(strRead, typeof(List<Person>));


            strRead.Close();
            stream.Close();

            return person[id];
        }
        public static void AddPerson(Person pers)
        {
            var lP  = Get();
            pers = new Person();
            lP.Add(pers);
            Add(lP);


        }


    }
}
