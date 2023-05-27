using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BigAccessment1_HotelsAPI.Models
{
    public class Room
    {
        [Key]
        public int Room_Id { get; set; }

        public int Hotel_Id { get; set; }
        [Required]
        
       
        public int Room_no { get; set; }

        public long Price { get; set; }

       public Hotel? hotels { get; set; }

       public ICollection<Reservation> ? Reservations { get; set; }


    }
}
