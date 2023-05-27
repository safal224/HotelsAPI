using BigAccessment1_HotelsAPI.Models;
using BigAccessment1_HotelsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservation _Irepo;

        public ReservationController(ReservationClass rc)
        {
            _Irepo = rc;
        }

        [HttpPost]
        public ActionResult AddUser(Reservation model)
        {
            if (ModelState.IsValid)
            {
                _Irepo.BookRoom(model);
                _Irepo.Save();


            }
            return Ok(model);
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var user = _Irepo.Get();
            return Ok(user);
        }

    }
}
