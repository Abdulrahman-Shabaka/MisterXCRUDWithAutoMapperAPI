using System;
using AutoMapper;
using MisterX.Models;
using MisterX.ViewModels;

namespace MisterX.AutoMapper
{
    public class StudentViewModelProfile:Profile
    {
        public StudentViewModelProfile()
        {
            CreateMap<StudentViewModel, Student>();
        }
    }
}

