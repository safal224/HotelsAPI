using BigAccessment1_HotelsAPI.Models;

namespace BigAccessment1_HotelsAPI.Repository
{
    public interface IReservation
    {
        public void BookRoom(Reservation res);
        public IEnumerable<Reservation> Get();
        public void Save();
    }
}
