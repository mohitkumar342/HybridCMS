﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HybridCMSEntities
{
    public class CMSLoginView
    {
        [DisplayName("Username")]
        [Required(ErrorMessage ="Username is required!!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RemenberMe { get; set; }
    }

    public class CMSChangePasswordView
    {
        [DisplayName("Current Password")]
        [Required(ErrorMessage = "Current Password is required!!")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DisplayName("New Password")]
        [Required(ErrorMessage = "New Password is required!!")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password character length should be in between 5 to 20.")]
        //[RegularExpression(" (?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{5,20})$", ErrorMessage = "Passwords must have at least 5 characters and contain at least one number and one alphabet.")]
        public string NewPassword { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required!!")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The New Password and Confirm Password fields do not match.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password character length should be in between 5 to 20.")]
        public string ConfirmPassword { get; set; }
    }
}
