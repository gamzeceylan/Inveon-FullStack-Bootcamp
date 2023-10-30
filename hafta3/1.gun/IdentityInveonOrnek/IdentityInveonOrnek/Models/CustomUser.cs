﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityInveonOrnek.Models
{
    public class CustomUser : IdentityUser
    {
        [Display(Name = "Adı & Soyadı")]
        public string FullName { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
    }
}
