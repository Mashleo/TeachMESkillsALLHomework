using Homework2710.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2710.Controllers
{
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly List<Person> _person;
        public PersonController(IOptions<List<Person>> person)
        {
            _person = person.Value;
        }

        [HttpGet("Get-Element")]
        public List<Person> GetElement() 
        {
            
            return WorkWithFile.Get();
        }

        [HttpGet("Get-Element/{id:int}")]
        public Person Getid([FromRoute] int id)
        {

            return WorkWithFile.Getid(id);
        }

        [HttpPost("save-new-data")]    //ВВОд ДАННЫХ
        public void SaveData([FromBody] Person pers)
        {
            WorkWithFile.AddPerson(pers);
        }



    }
}
