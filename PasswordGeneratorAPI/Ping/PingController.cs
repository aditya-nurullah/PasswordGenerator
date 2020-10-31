using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PasswordGeneratorAPI.Ping
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Pong!" };
        }
    }
}
