using BigAccessment1_HotelsAPI.Models;

namespace BigAccessment1_HotelsAPI.Repository
{
    public interface InterfaceInformation
    {
        public IEnumerable<Information> GetInformation();

        public Information GetById(int Id);
        public void Insert(Information Info);
        public void Update(Information Info);
        public Information Delete(int Id);
        public void Save();
    }
}
