using BigAccessment1_HotelsAPI.Models;

namespace BigAccessment1_HotelsAPI.Repository
{
    public interface IHotel
    {
        public IEnumerable<Hotel> GetHotels();

        public Hotel ? GetById(int Id);
        public void Insert(Hotel hotel);
        public void Update(Hotel hotel);
        public Hotel ? Delete(int Id);
        public void Save();
    }
}
