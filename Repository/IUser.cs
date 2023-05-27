using BigAccessment1_HotelsAPI.Models;

namespace BigAccessment1_HotelsAPI.Repository
{
    public interface IUser
    {
        public IEnumerable<User> GetUsers();

        public User ? GetById(int Id);
        public void Insert(User user);
        public void Update(User user);
        public User ? Delete(int Id);
        public void Save();
    }
}
