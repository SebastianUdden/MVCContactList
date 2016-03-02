using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCContactList.ViewModels
{
    public class ListPersonViewModel
    {
        public ListPersonViewModel()
        {

        }

        public ListPersonViewModel(string name, string email, bool showAsHighlighted)
        {
            Name = name;
            Email = email;
            ShowAsHighlighted = showAsHighlighted;
        }

        [Display(Name = "Förnamn")]
        public string Name { get; set; }

        [Display(Name = "E-post")]
        public string Email { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "Email must end with acme.com")]
        public bool ShowAsHighlighted{ get; set; }



    }
}
