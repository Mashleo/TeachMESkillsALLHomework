﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Homework2510.Models
{
    public  static class WorkWithFile
    {
        public static string ReturnTextFronFile(string path)
        {
            FileStream stream = File.Open(path, FileMode.OpenOrCreate);
           
            StreamReader strRead = new StreamReader(stream);
         
            var a = strRead.ReadToEnd();
           
            
            strRead.Close();
            stream.Close();
            return a;
        }
        public static List<Cars> ReturnListFromText(string path)
        {
            FileStream stream = File.Open(path, FileMode.OpenOrCreate);
            StreamReader strRead = new StreamReader(stream);
            JsonSerializer js = new JsonSerializer();
            var listCar = (List<Cars>)js.Deserialize(strRead, typeof(List<Cars>));
            return listCar;
        }

    }
    
}
