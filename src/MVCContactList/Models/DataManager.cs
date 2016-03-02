using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCContactList.ViewModels;

namespace MVCContactList.Models
{
    public class DataManager
    {
        static List<ListPersonViewModel> ArrayOfContacts = new List<ListPersonViewModel>();
        public ListPersonViewModel[] GetAllContacts()
        {
            var contacts1 = new Person("Mikael", "mikael.brunnberg@gmail.com");
            var contacts2 = new Person("Sebastian", "sebastian.udden@gmail.com");

            var LPVM1 = new ListPersonViewModel(contacts1.Name, contacts2.Email, false);
            var LPVM2 = new ListPersonViewModel(contacts2.Name, contacts2.Email, false);

            ArrayOfContacts.Add(LPVM1);
            ArrayOfContacts.Add(LPVM2);

            return ArrayOfContacts
                .OrderBy(o => o.Name)
                .Select(o=> )
                .ToArray();
        }

        public void CreateContact()
        {
        }

        public AddPerson(CreatePersonViewModel )
        {

        }
    }
}
