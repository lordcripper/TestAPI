using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Values : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"val","val1"};
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Puneet Singh";
        } 
    }
}
