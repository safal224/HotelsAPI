using BigAccessment1_HotelsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BigAccessment1_HotelsAPI.Repository
{
    public class PriceRangeClass:IPriceRange
    {

        private readonly MainDbContext _context;

        public PriceRangeClass(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<PriceRange> GetDetails()
        {
            return _context.PriceRanges.ToList();
        }

        public MainDbContext Get_context()
        {
            return _context;
        }

        public PriceRange GetById(int Id)
        {
            PriceRange Prange = _context.PriceRanges.Find(Id);
            return Prange;
        }

        public void Insert(PriceRange Prange)
        {
            _context.PriceRanges.Add(Prange);
            Save();
        }

        public void Update(PriceRange Prange)
        {
            _context.Entry(Prange).State = EntityState.Modified;
            Save();
        }

        public PriceRange Delete(int Id)
        {
            PriceRange Prange = _context.PriceRanges.Find(Id);
            try
            {
                if (Prange != null)
                {
                    _context.Remove(Prange);
                    Save();
                }
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message+" "+"Invalid  ID, request cannot be proceed.");

            }

            return Prange;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
