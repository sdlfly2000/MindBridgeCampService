﻿using Application.Services.LearningRoom.Contracts;
using Application.LearningRoom;
using System.Collections.Generic;

namespace Application.Services.LearningRoom
{
    public interface ILearningRoomService
    {
        GetResponse GetAvailableRooms();

        void CreateRoom(string loginToken, LearningRoomModel model);

        GetResponse JoinRoom(string loginToken, string roomId);

        IList<ParticipantModel> GetParticipants(string roomId);
    }
}
