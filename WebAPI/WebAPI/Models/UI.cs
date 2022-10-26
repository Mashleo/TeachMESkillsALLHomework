using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public static class UI
    {
        public static List<Person> Start()
        {
            List<Person> listPerson = WriteInTableBaseData();
           

            //Table.Print(WorkWithFile.Get());


            //listPerson.Add(WorkWithFile.AddFromConsole());
            //WorkWithFile.Add(listPerson);
            //Table.Print(WorkWithFile.Get());


            //listPerson.Add(WorkWithFile.AddFromConsole());


            //WorkWithFile.Add(listPerson);
            //Table.Print(WorkWithFile.Get());
            return listPerson;
        }





        public static List<Person> WriteInTableBaseData()
        {

            var human1 = new Person("Leo", 25, "BEL", "Brest", "Sovet");
            var human2 = new Person("Nick", 18, "UA", "Kiev", "Lenina");
            var human3 = new Person("Alex", 35, "USA", "Cali", "25st");
            var human4 = new Person("Oldman", 99, "UK", "Chester", "pr. Diana");
            List<Person> listT = new List<Person>();

            listT.Add(human1);
            listT.Add(human2);
            listT.Add(human3);
            listT.Add(human4);
            WorkWithFile.Add(listT);
           
            return listT;
        }
       
    }
}
