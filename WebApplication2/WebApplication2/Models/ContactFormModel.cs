﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fyll i en email ditt stolpskott!")]
        public string Email { get; set; }

        public string Message { get; set; }
    }
}