using System;
using AutoMapper;
using MisterX.Models;
using MisterX.ViewModels;

namespace MisterX.AutoMapper
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentViewModel>();
        }
    }
}

