using System.ComponentModel.DataAnnotations;

namespace BigAccessment1_HotelsAPI.Models
{
    public class Reservation
    {
        [Key]
        public int Reservation_Id { get; set; }

        [Required]
        public int RoomId { get; set; }
        [Required]
        public int User_Id { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

       
        public Room ? Room { get; set; }
        public User ? User { get; set; }


    }

}
