using BigAccessment1_HotelsAPI.Models;
using Microsoft.EntityFrameworkCore;
using static BigAccessment1_HotelsAPI.Repository.ReservationClass;

namespace BigAccessment1_HotelsAPI.Repository
{
    public class ReservationClass:IReservation
    {
        
            private readonly MainDbContext _context;

            public ReservationClass(MainDbContext context)
            {
                _context = context;
            }
             public MainDbContext Get_context()
              {
                    return _context;
               }
        public void BookRoom(Reservation reservation)
            {
                bool isRoomAvailable = !_context.Reversations.Any(r => r.RoomId == reservation.RoomId && r.CheckInDate <= reservation.CheckOutDate && r.CheckOutDate >= reservation.CheckInDate);
                var user = _context.Users.Find(reservation.User_Id);
                if (isRoomAvailable && user!=null)
                {
                    _context.Reversations.Add(reservation);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("The room is already booked for the selected dates.");
                }
            }

        public IEnumerable<Reservation> Get()
        {
            return _context.Reversations.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        }

    }

