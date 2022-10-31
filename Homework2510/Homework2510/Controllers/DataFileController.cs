using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework2510.Interfaces;
using Homework2510.Models;

namespace Homework2510.Controllers
{
    [Route("DataFile")]
    [ApiController]
    public class DataFileController : ControllerBase
    {

        private readonly IWorkWithFile _iworkWithFile;
        private readonly string _name;

        public DataFileController(IConfiguration config, IWorkWithFile iWorkWithFile)
        {
            _name = config.GetValue<string>("DataFile");
            _iworkWithFile = iWorkWithFile;
        }

        [HttpGet("Get-Name")]
        public string GetName()
        {
            return _name;
        }

        [HttpGet("Get-Text-From-file")]
        public string GetTextFromFile()
        {
            return _iworkWithFile.ReturnTextFronFile(_name);
        }

        [HttpGet("Get-File-From-JSON")]
        public List<Cars> GetFileFromJson()
        {
            return _iworkWithFile.ReturnListFromText(_name);
        }
    }
}
