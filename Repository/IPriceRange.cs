using BigAccessment1_HotelsAPI.Models;

namespace BigAccessment1_HotelsAPI.Repository
{
    public interface IPriceRange
    {
        public IEnumerable<PriceRange> GetDetails();

        public PriceRange GetById(int Id);
        public void Insert(PriceRange Pr);
        public void Update(PriceRange pr);
        public PriceRange Delete(int Id);
        public void Save();
    }
}
