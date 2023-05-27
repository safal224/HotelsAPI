using BigAccessment1_HotelsAPI.Models;
using BigAccessment1_HotelsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotel _Irepo;

        public HotelController(HotelClass hc)
        {
            _Irepo = hc;
        }

        [HttpPost]
        public ActionResult AddHotel(Hotel model)
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
            var hotel = _Irepo.GetHotels();
            return Ok(hotel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {

            var hotel = _Irepo.GetHotels();
            return Ok(hotel);
        }
        [Authorize]
        [HttpDelete]

        public IActionResult DeleteById(int id)
        {
            var hotel = _Irepo.Delete(id);
            return Ok(hotel);
        }
    }
}
