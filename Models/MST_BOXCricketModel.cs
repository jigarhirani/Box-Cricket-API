using System.ComponentModel.DataAnnotations;

namespace APIBOXCricket.Models
{
    public class MST_BOXCricketModel
    {
        public int? BOXCricketID { get; set; }

        [Required(ErrorMessage = "Please enter the BOX Cricket Name.")]
        public string BOXCricketName { get; set; }

        public string? OwnerName { get; set; }

        [Required(ErrorMessage = "Please enter the Address of the BOX Cricket.")]
        public string Address { get; set; }

        public string Contact { get; set; }

        public string? CountryName { get; set; }

        public string? StateName { get; set; }

        public string? CityName { get; set; }

        public string? BOXCricketImagePath1 { get; set; }
        public string? BOXCricketImagePath2 { get; set; }
    }
}
