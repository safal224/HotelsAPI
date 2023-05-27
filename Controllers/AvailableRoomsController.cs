using BigAccessment1_HotelsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigAccessment1_HotelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailableRoomsController : ControllerBase
    {

        private readonly MainDbContext dbContext;

        public AvailableRoomsController(MainDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IQueryable<Room> Get(int hotelId, DateTime checkInDate, DateTime checkOutDate) {
            var availableRooms = dbContext.Rooms
            .Include(r => r.hotels)
            .Include(r => r.Reservations)
            .Where(r => r.Hotel_Id == hotelId && !r.Reservations.Any(res =>
                !(res.CheckOutDate <= checkInDate || res.CheckInDate >= checkOutDate)));

            return availableRooms;


        }
    }
}
