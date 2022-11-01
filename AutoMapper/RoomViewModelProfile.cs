using System;
using AutoMapper;
using MisterX.Models;
using MisterX.ViewModels;

namespace MisterX.AutoMapper
{
    public class RoomViewModelProfile:Profile
    {
        public RoomViewModelProfile()
        {
            CreateMap<RoomViewModel, Room>();
        }
    }
}

