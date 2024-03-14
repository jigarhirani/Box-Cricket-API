using System.ComponentModel.DataAnnotations;

namespace APIBOXCricket.Models
{
    public class BookingModel
    {
        public int UserID { get; set; }

        public int? BookingID { get; set; }

        [Required(ErrorMessage = "Please choose the BOX Cricket.")]
        public int BOXCricketID { get; set; }

        [Required(ErrorMessage = "Please choose the Ground.")]
        public int GroundID { get; set; }

        [Required(ErrorMessage = "Please choose the Booking Date.")]
        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Please Enter BookingAmount.")]
        public decimal BookingAmount { get; set; }

        public string? Slots { get; set; }

        public string? Status { get; set; }
        public string? Remarks { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }

    public class MST_BookingListModel
    {
        public string? GroundName { get; set; }

        public string? BOXCricketName { get; set; }

        public DateTime BookingDate { get; set; }

        public string? SlotDetails { get; set; }

        public string? TotalSlotsBooked { get; set; }

        public decimal BookingAmount { get; set; }

        public string Status { get; set; }

        public DateTime Created { get; set; }
    }
}
