using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Homework2510.Interfaces;

namespace Homework2510.Models
{
    public class WorkWithFile : IWorkWithFile
    {
        public string ReturnTextFronFile(string path)
        {
            FileStream stream = File.Open(path, FileMode.OpenOrCreate);

            StreamReader strRead = new StreamReader(stream);

            var resultString = strRead.ReadToEnd();

            strRead.Close();
            stream.Close();
            return resultString;
        }
        public List<Cars> ReturnListFromText(string path)
        {
            FileStream stream = File.Open(path, FileMode.OpenOrCreate);

            StreamReader strRead = new StreamReader(stream);

            JsonSerializer js = new JsonSerializer();

            var listCar = (List<Cars>)js.Deserialize(strRead, typeof(List<Cars>));

            strRead.Close();
            stream.Close();
            return listCar;
        }

    }



}
