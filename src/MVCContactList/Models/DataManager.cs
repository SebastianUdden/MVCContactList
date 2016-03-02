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
            #region Skapar två hrdkodade kontakter
            var contacts1 = new Person("Mikael", "mikael.brunnberg@gmail.com");
            var contacts2 = new Person("Sebastian", "sebastian.udden@gmail.com");

            var LPVM1 = new ListPersonViewModel(contacts1.Name, contacts2.Email, false);
            var LPVM2 = new ListPersonViewModel(contacts2.Name, contacts2.Email, false);
            var LPVM3 = new ListPersonViewModel("Pontus", "Pontus@acme.se", true);

            ArrayOfContacts.Add(LPVM1);
            ArrayOfContacts.Add(LPVM2);
            ArrayOfContacts.Add(LPVM3);
            #endregion

            return ArrayOfContacts
                .OrderBy(o => o.Name)
                .ToArray();
        }

        public void CreateContact()
        {
        }

        //public AddPerson(CreatePersonViewModel)
    }
}
