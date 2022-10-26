using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
       

        [HttpGet] 
        public List<Person> Get()
        {
            return UI.Start();
            
        }
       

    }
}
