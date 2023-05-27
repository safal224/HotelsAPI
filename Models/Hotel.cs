using System.ComponentModel.DataAnnotations;

namespace BigAccessment1_HotelsAPI.Models
{
    public class Hotel
    {
        [Key]
        public int Hotel_Id { get; set; }
        [Required]
        public string ?Hotel_Name { get; set; }
        [Required]
        public int Location_Id { get; set; }
        [Required]
        public int PriceRange_Id { get; set; }
        [Required]
        public string ? Amenities { get; set; }
        [Required]
        public int Information_Id { get; set; }
        public Location ?Location { get; set; }
        public Information ?Information { get; set; }
        public PriceRange ? Pricerange { get; set; }
        public List<Room>? Room { get; set; }


    }
}
