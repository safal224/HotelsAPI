using BigAccessment1_HotelsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BigAccessment1_HotelsAPI.Repository
{
    public class UserClass:IUser
    {
        private readonly MainDbContext _context;

        public UserClass(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public MainDbContext Get_context()
        {
            return _context;
        }

        public User? GetById(int Id)
        {

            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            User user = _context.Users.Find(Id);
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (user == null)
            {
                return null;
            }


            return user;


        }

        public void Insert(User user)
        {
            
                
             _context.Users.Add(user);
             Save();

         }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            Save();
        }

        public User? Delete(int Id)
        {
            User user = _context.Users.Find(Id);
            try
            {
                if (user != null)
                {
                    _context.Remove(user);
                    Save();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message + "Invalid  ID, request cannot be proceed.");

            }

            return user;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
