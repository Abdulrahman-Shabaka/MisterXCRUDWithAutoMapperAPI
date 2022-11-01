using System;
using AutoMapper;
using MisterX.Models;
using MisterX.ViewModels;

namespace MisterX.AutoMapper
{
    public class RoomProfile:Profile
    {
        public RoomProfile()
        {
            CreateMap<Room, RoomViewModel>();
        }
    }
}

