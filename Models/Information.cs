using System.ComponentModel.DataAnnotations;

namespace BigAccessment1_HotelsAPI.Models
{
    public class Information
    {
        [Key]
        public int Information_Id { get; set; }

        public string ? Owner_Name { get; set; }

        public string ? Manager_Name { get; set; }

        
        public int Total_Room { get; set; }
        public List<Hotel> ? Hotel { get; set; }
    }
}
