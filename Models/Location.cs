using System.ComponentModel.DataAnnotations;

namespace BigAccessment1_HotelsAPI.Models
{
    public class Location
    {
        [Key]
        public int Location_Id { get; set; }

        [Required]
        public string ? Address { get; set; } 
        [Required]
        public string ? City { get; set;}

        [Required]
        public string ?Country { get; set;}


        public List<Hotel> ?Hotel { get; set; }


    }
}
