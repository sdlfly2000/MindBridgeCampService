﻿using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Application.Services.LearningRoom;
using Application.LearningRoom;

namespace MindBridgeCampServer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LearningRoomController : ControllerBase
    {
        private readonly ILearningRoomService _learningRoomService;

        public LearningRoomController(ILearningRoomService learningRoomService)
        {
            _learningRoomService = learningRoomService;
        }

        [HttpGet]
        public IActionResult GetAvailableRooms()
        {
            var availableRooms = _learningRoomService.GetAvailableRooms();

            return Ok(JsonConvert.SerializeObject(availableRooms.LearningRooms));
        }

        [HttpPost]
        public IActionResult CreateRoom([FromBody] LearningRoomModel model)
        {
            _learningRoomService.CreateRoom(model);

            return Ok();
        }
    }
}
