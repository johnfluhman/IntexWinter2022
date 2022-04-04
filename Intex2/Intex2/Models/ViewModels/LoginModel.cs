﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Intex2.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
