using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
      private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values = _roomService.TGetByID(id);
            _roomService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _roomService.TGetByID(id);
            return Ok(values);
        }
    }
}
