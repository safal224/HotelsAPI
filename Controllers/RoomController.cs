using BigAccessment1_HotelsAPI.Models;
using BigAccessment1_HotelsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly IRoom _Irepo;

        public RoomController(RoomClass rc)
        {
            _Irepo = rc;
        }

        [HttpPost]
        public ActionResult AddRoom(Room model)
        {
            if (ModelState.IsValid)
            {
                _Irepo.Insert(model);
                _Irepo.Save();


            }
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var room = _Irepo.GetRooms();
            return Ok(room);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {

            var room = _Irepo.GetRooms();
            return Ok(room);
        }
        [Authorize]
        [HttpDelete]

        public IActionResult DeleteById(int id)
        {
            var room = _Irepo.Delete(id);
            return Ok(room);
        }
    }
}
