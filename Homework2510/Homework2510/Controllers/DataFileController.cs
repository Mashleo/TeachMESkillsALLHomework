using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Homework2510.Models;

namespace Homework2510.Controllers
{
    [Route("DataFile")]
    [ApiController]
    public class DataFileController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly string _name;
        public DataFileController(IConfiguration config)
        {
           
            _config = config;
            _name = _config.GetValue<string>("DataFile");
        }
        [HttpGet("Get_Name")]
        public string GetName()
        {
            return _name;
        }
        [HttpGet("Get_Text_From_file")]
        public string GetTextFromFile()
        {
            
           return WorkWithFile.ReturnTextFronFile(_name);
        }
        [HttpGet("Get_File_From_JSON")]
        public List<Cars> GetFileFromJson()
        {

            return WorkWithFile.ReturnListFromText(_name);
        }
    }
}
