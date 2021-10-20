using Covid.Models;
using Covid.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Covid19Controller : ControllerBase
    {
        private readonly Covid19Services _services;
        public Covid19Controller(Covid19Services services)
        {
            _services = services;
        }
        [HttpGet]
        public async Task<ActionResult<Stats>> WorldData()
        {
            return await _services.GetWorldData();
        }
    }
}
