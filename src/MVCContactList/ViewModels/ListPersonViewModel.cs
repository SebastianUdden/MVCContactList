using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCContactList.ViewModels
{
    public class ListPersonViewModel
    {
        [Display(Name = "First Name")]
        public string Name { get; set; }
        public string Email { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Email must end with acme.com")]
        public bool ShowAsHighlighted{ get; set; }



    }
}
