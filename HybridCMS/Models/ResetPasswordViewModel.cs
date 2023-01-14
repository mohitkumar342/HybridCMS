﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HybridCMS.Models
{
    public class ResetPasswordViewModel
    {
        [DisplayName("New Password")]
        [Required(ErrorMessage = "New Password is required!!")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password character length should be in between 5 to 20.")]
        public string NewPassword { get; set; }


        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required!!")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The New Password and Confirm Password fields do not match.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Password character length should be in between 5 to 20.")]
        public string ConfirmPassword { get; set; }
    }
}