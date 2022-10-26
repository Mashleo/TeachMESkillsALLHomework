using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        private readonly IHomeSer _iHomeSer;
        private readonly IConfiguration _config;

        public HomeController(IHomeSer iHomeSer, IConfiguration config)
        {
            _iHomeSer = iHomeSer;
            _config = config;
        }
        [HttpGet("home123")]
        public string Get()
        {
            return "";
        }
        [HttpGet("say")]
        public string Say()
        {
           return _iHomeSer.Say();
        }
        [HttpGet("secret-key")]
        public string GettKeyy()
        {
            return _config.GetValue<string>("Sekrtr");
        }
    }
}
