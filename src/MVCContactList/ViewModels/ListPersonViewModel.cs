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

        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
