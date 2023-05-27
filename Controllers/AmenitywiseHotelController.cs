using BigAccessment1_HotelsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenitywiseHotelController : ControllerBase
    {
        private readonly MainDbContext _mainDbContext;


        public AmenitywiseHotelController(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;

        }
        [HttpGet]
        public IActionResult GetHotelByAmenities(string amenity)
        {
            var c = _mainDbContext.Hotels
            .Where(h => h.Amenities.Contains(amenity))
            .ToList();
            return Ok(c);
        }
    }
}
