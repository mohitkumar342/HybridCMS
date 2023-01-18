﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HybridCMS.Models
{
    public class AssetViewModel
    {
        public Int64 AssetId { get; set; }

        [Required(ErrorMessage ="Name is Required!!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name character length should be in between 3 to 100.")]
        public string Name { get; set; }
        public Int64 UserId { get; set; }
        public int AssetTypeId { get; set; }
        [DisplayName("Display URL")]
        [Required(ErrorMessage ="URL is Required!!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "URL character length should be in between 5 to 50.")]
        [Remote("IsUrlAvailable", "Admin", HttpMethod = "Post", ErrorMessage = "URL already exist.", AdditionalFields = "initialURL")]
        public string URL { get; set; }
        [StringLength(100, ErrorMessage = "URL character length should be less than 100.")]
        public string Description { get; set; }
        [DisplayName("Photo")]
        public string ProfilePicture { get; set; }

        public string initialURL
        {
            get
            {
                if (URL != null)
                {
                    return URL.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}