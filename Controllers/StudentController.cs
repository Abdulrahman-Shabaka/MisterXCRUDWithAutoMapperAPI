using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MisterX.Interfaces;
using MisterX.Models;
using MisterX.Repositories;
using MisterX.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MisterX.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        private readonly IStudent _repo;
        private readonly IMapper _mapper;
        public StudentController(IStudent repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

       [HttpGet]
       public IActionResult GetAll()
       {
            List<StudentViewModel> studentViewModels = _mapper.Map<List<StudentViewModel>>(_repo.GetAll());
            return Ok(studentViewModels);
       }

        [HttpGet]
        public IActionResult FindById(int Id)
        {

            StudentViewModel studentViewModel = _mapper.Map<StudentViewModel>(_repo.FindById(Id));
            return Ok(studentViewModel);
        }

        [HttpPost]
        public IActionResult Add(StudentViewModel studentViewModel)
        {
            Student student = _mapper.Map<Student>(studentViewModel);
            StudentViewModel _studentViewMode = _mapper.Map<StudentViewModel>(_repo.Create(student));
            return Ok(_studentViewMode);
        }

        [HttpPut]
        public IActionResult Update(StudentViewModel studentViewModel)
        {
            Student student = _mapper.Map<Student>(studentViewModel);
            StudentViewModel _studentViewMode = _mapper.Map<StudentViewModel>(_repo.Update(student));
            return Ok(_studentViewMode);
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            return Ok(_repo.Delete(Id));
        }
    }
}

