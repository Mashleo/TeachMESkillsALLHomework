using Homework2510.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2510.Interfaces
{
    public interface IWorkWithFile
    {
        public string ReturnTextFronFile(string path);
        public List<Cars> ReturnListFromText(string path);

    }
}
