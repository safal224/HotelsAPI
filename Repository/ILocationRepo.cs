using BigAccessment1_HotelsAPI.Models;
using System.Numerics;

namespace BigAccessment1_HotelsAPI.Repository
{
    public interface ILocationRepo
    {
        public IEnumerable<Location> GetLocation();

        public Location GetById(int Id);
        public void Insert(Location loction);
        public void Update(Location location);
        public Location Delete(int Id);
        public void Save();
    }
}
