using BigAccessment1_HotelsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BigAccessment1_HotelsAPI.Repository
{
    public class HotelClass:IHotel
    {
        private readonly MainDbContext _context;

        public HotelClass(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Hotel> GetHotels()
        {
            return _context.Hotels.ToList();
        }

        public MainDbContext Get_context()
        {
            return _context;
        }

        public Hotel? GetById(int Id)
        {

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Hotel hotel = _context.Hotels.Find(Id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (hotel == null)
            {
                return null;
            }


              return hotel;
           
            
        }

        public void Insert(Hotel hotel)
        {
            try
            {
                var info = _context.Informations.Find(hotel.Information_Id);
                var loc = _context.Locations.Find(hotel.Location_Id);
                var price = _context.PriceRanges.Find(hotel.PriceRange_Id);
                if(price != null && loc!=null && info != null)
                {

                    _context.Hotels.Add(hotel);
                    Save();

                }

                
                
            } 
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message + "Invalid  ID, request cannot be proceed.");

            }
        }

        public void Update(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            Save();
        }

        public Hotel ? Delete(int Id)
        {
            Hotel hotel = _context.Hotels.Find(Id);
            try
            {
                if (hotel != null)
                {
                    _context.Remove(hotel);
                    Save();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message + "Invalid  ID, request cannot be proceed.");

            }

            return hotel;
        }
        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
