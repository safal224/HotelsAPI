using BigAccessment1_HotelsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BigAccessment1_HotelsAPI.Repository
{
    public class LocationClass:ILocationRepo
    {
        private readonly MainDbContext _context;

        public LocationClass(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Location> GetLocation()
        {
            return _context.Locations.ToList();
        }

        public MainDbContext Get_context()
        {
            return _context;
        }

        public Location GetById(int Id)
        {
           Location location = _context.Locations.Find(Id);
            return location;
        }

        public void Insert(Location location)
        {
            _context.Locations.Add(location);
            Save();
        }

        public void Update(Location location)
        {
            _context.Entry(location).State = EntityState.Modified;
            Save();
        }

        public Location Delete(int Id)
        {
            Location location = _context.Locations.Find(Id);
            try
            {
                if (location != null)
                {
                    _context.Remove(location);
                    Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return location;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}
