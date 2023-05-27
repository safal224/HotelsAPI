using BigAccessment1_HotelsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BigAccessment1_HotelsAPI.Repository
{
    public class InformationClass : InterfaceInformation
    {

       
            private readonly MainDbContext _context;

            public InformationClass(MainDbContext context)
            {
                _context = context;
            }
            public IEnumerable<Information> GetInformation()
            {
                return _context.Informations.ToList();
            }

            public MainDbContext Get_context()
            {
                return _context;
            }

            public Information GetById(int Id)
            {
                Information information = _context.Informations.Find(Id);
                
                return information;
            }

            public void Insert(Information information)
            {
                _context.Informations.Add(information);
                Save();
            }

            public void Update(Information information)
            {
                _context.Entry(information).State = EntityState.Modified;
                Save();
            }

            public Information Delete(int Id)
            {
                Information information = _context.Informations.Find(Id);
                try
                {
                    if (information != null)
                    {
                        _context.Remove(information);
                        Save();
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message + "Invalid  ID, request cannot be proceed.");

                }

            return information;
            }
            public void Save()
            {
                _context.SaveChanges();
            }


        }
    }
