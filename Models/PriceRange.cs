using System.ComponentModel.DataAnnotations;

namespace BigAccessment1_HotelsAPI.Models
{
    public class PriceRange
    {
        [Key]
        public int PriceRangeId { get; set; }

        [Required]
        public string ? Range { get; set; }

        public ICollection<Hotel>? Hotel { get; set; }


    }
}
