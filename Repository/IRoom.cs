using BigAccessment1_HotelsAPI.Models;

namespace BigAccessment1_HotelsAPI.Repository
{
    public interface IRoom
    {
        public IEnumerable<Room> GetRooms();

        public Room? GetById(int Id);
        public void Insert(Room room);
        public void Update(Room room);
        public Room? Delete(int Id);
        public void Save();
    }
}
