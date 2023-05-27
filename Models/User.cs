using System.ComponentModel.DataAnnotations;

namespace BigAccessment1_HotelsAPI.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        [Required]
        public string ? Username { get; set; }

        [Required]
        public string ? Email { get; set; }

       
        public string ? FirstName { get; set; }
        public string ? LastName { get; set; }
        public string ? PhoneNumber { get; set; }
        

      
        public ICollection<Reservation> ? Reservations { get; set; }
    }

}
