using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCContactList.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter an email with an @ sign.")]
        public string Email { get; set; }

        [Display(Name = "I accept terms and conditions.")]
        public bool AcceptTerms { get; set; }
    }
}
