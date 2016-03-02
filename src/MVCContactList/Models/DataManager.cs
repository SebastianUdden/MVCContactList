using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCContactList.ViewModels;

namespace MVCContactList.Models
{
    public class DataManager
    {
        static List<ListPersonViewModel> ListOfContacts = new List<ListPersonViewModel>();
        public ListPersonViewModel[] GetAllContacts()
        {
            return ListOfContacts
                .OrderBy(o => o.Name)
                .Select(o=>)
                .ToArray();
        }

        public void CreateContact()
        {
        }

        public AddPerson(CreatePersonViewModel)
    }
}
