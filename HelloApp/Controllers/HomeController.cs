using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public IActionResult Get()
        {
           return Ok("Hello Reyaz!!!");
        }

        [Route("{name}")]
        public IActionResult Get(string name)
        {
            return Ok($"Hello {name}!!!");
        }
    }
}
