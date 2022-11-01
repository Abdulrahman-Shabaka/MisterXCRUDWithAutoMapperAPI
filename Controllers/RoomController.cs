using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MisterX.Interfaces;
using MisterX.Models;
using MisterX.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MisterX.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class RoomController : Controller
    {
        private readonly IRoom _repo;
        private readonly IMapper _mapper;

        public RoomController(IRoom repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<RoomViewModel>roomViewModels = _mapper.Map<List<RoomViewModel>>(_repo.GetAll());
            return Ok(roomViewModels);
        }

        [HttpGet]
        public IActionResult FindById(int Id)
        {
            RoomViewModel roomViewModel = _mapper.Map<RoomViewModel>(_repo.FindById(Id));
            return Ok(roomViewModel);
        }

        [HttpPost]
        public IActionResult Add(RoomViewModel roomViewModel)
        {
            Room room = _mapper.Map<Room>(roomViewModel);
            RoomViewModel _roomViewModel = _mapper.Map<RoomViewModel>(_repo.Create(room));
            return Ok(_roomViewModel);
        }

        [HttpPatch]
        public IActionResult Update(RoomViewModel roomViewModel)
        {
            Room room = _mapper.Map<Room>(roomViewModel);
            RoomViewModel _roomViewModel = _mapper.Map<RoomViewModel>(_repo.Update(room));
            return Ok(_roomViewModel);
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            return Ok(_repo.Delete(Id));
        }
    }
}

