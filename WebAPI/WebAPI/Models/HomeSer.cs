using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class HomeSer : IHomeSer
    {
        public string Say()
        {
            return "Hello";
        }
    }
    
   
    public interface IHomeSer
    {
        string Say();
    }
   
  
}
