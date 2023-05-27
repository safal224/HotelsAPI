using BigAccessment1_HotelsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationwiseHotelController : ControllerBase
    {

        private readonly MainDbContext _mainDbContext;


        public LocationwiseHotelController(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;

        }
        [HttpGet]
        public IActionResult GetHotelByLocation(string city)
        {
            var c = _mainDbContext.Locations.FirstOrDefault(l => l.City == city);

            if (c != null)
            {
                var q = (from s in _mainDbContext.Hotels
                         join pd in _mainDbContext.Locations on s.Location_Id equals pd.Location_Id
                         where pd.City == city
                         select new
                         {
                             s.Hotel_Name,
                             pd.City
                         }).ToList();

                return Ok(q);
            }
            return null;
        }

        

    }

}