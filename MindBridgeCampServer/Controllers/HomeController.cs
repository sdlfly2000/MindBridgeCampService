﻿using Microsoft.AspNetCore.Mvc;
using Common.Core.LogService;

namespace MindBridgeCampServer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult IsAlive()
        {
            LogService.Info<HomeController>("IsAlive");
            return Ok("Mind Bridge Camp Service is alive.");
        }
    }
}