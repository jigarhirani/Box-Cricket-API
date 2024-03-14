﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APIBOXCricket.Models
{
    public class MST_UserModel
    {
        public int? UserID { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public int CityID { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string? ProfilePhotoPath { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }

    public class MST_User_ProfileAddModel
    {
        public int? UserID { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Please Enter Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please Enter the Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password should contain at least one lowercase letter, one uppercase letter, one digit, and one special character. Minimum length is 8 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Your Phone No.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please choose the Country.")]
        public int CountryID { get; set; }

        [Required(ErrorMessage = "Please choose the State.")]
        public int StateID { get; set; }

        [Required(ErrorMessage = "Please choose the City.")]
        public int CityID { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Please upload your profile photo")]
        [DisplayName("Profile Photo")]
        public IFormFile? File { get; set; }

        public string? ProfilePhotoPath { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }

    public class MST_User_ProfileUpdateModel
    {
        public int? UserID { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Please Enter Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Your Phone No.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please choose the Country.")]
        public int CountryID { get; set; }

        [Required(ErrorMessage = "Please choose the State.")]
        public int StateID { get; set; }

        [Required(ErrorMessage = "Please choose the City.")]
        public int CityID { get; set; }

        public string? ProfilePhotoPath { get; set; }
    }

    public class MST_User_PasswrodChangeModel
    {
        public int? UserID { get; set; }

        [Required(ErrorMessage = "Please Enter the Current Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password should contain at least one lowercase letter, one uppercase letter, one digit, and one special character. Minimum length is 8 characters.")]
        public string CurruntPassword { get; set; }

        [Required(ErrorMessage = "Please Enter the New Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password should contain at least one lowercase letter, one uppercase letter, one digit, and one special character. Minimum length is 8 characters.")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Please Confirm the Password")]
        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
