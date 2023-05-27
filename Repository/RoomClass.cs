using BigAccessment1_HotelsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BigAccessment1_HotelsAPI.Repository
{
    public class RoomClass:IRoom
    {
        private readonly MainDbContext _context;

        public RoomClass(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Room> GetRooms()
        {
            return _context.Rooms.ToList();
        }

        public MainDbContext Get_context()
        {
            return _context;
        }

        public Room? GetById(int Id)
        {

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Room room = _context.Rooms.Find(Id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (room == null)
            {
                return null;
            }


            return room;


        }

        public void Insert(Room room)
        {

            var hotel = _context.Hotels.Find(room.Hotel_Id);
            if(hotel != null)
            {
                _context.Add(room);
                Save();
            }

            
        }

        public void Update(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            Save();
        }

        public Room? Delete(int Id)
        {
            Room room = _context.Rooms.Find(Id);
            try
            {
                if (room != null)
                {
                    _context.Remove(room);
                    Save();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message + "Invalid  ID, request cannot be proceed.");

            }

            return room;
        }
        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
