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
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Must be a valid e-mail address")]
        public string Email { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Must accept terms and conditions")]
        public bool AcceptTerms { get; set; }
    }
}
