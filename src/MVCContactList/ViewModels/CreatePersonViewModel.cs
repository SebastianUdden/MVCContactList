﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCContactList.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Please enter an e-mail.")]
        [EmailAddress(ErrorMessage = "Must be a valid e-mail address")]
        public string Email { get; set; }

        [Display(Name = "Check box to accept terms.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept terms and conditions to proceed")]
        public bool AcceptTerms { get; set; }
    }
}
