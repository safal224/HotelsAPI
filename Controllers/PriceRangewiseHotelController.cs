using BigAccessment1_HotelsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceRangewiseHotelController : ControllerBase
    {
        private readonly MainDbContext _mainDbContext;


        public PriceRangewiseHotelController(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;

        }
        [HttpGet]
        public IActionResult GetHotelByLocation(string type)
        {
            var c = _mainDbContext.PriceRanges.FirstOrDefault(l => l.Range == type);

            if (c != null)
            {
                var q = (from s in _mainDbContext.Hotels
                         join pd in _mainDbContext.PriceRanges on s.PriceRange_Id equals pd.PriceRangeId
                         where pd.Range == type
                         select new
                         {
                             s.Hotel_Name,
                             pd.Range
                         }).ToList();

                return Ok(q);
            }
            return null;
        }

    }
}
