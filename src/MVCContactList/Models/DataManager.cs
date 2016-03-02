using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCContactList.ViewModels;

namespace MVCContactList.Models
{
    public class DataManager
    {
        static List<Person> ListOfPeople = new List<Person>();
        public ListPersonViewModel[] GetAllContacts()
        {
            var contacts1 = new Person("Mikael", "mikael.brunnberg@gmail.com");
            var contacts2 = new Person("Sebastian", "sebastian.udden@gmail.com");

            var LPVM1 = new ListPersonViewModel(contacts1.Name, contacts2.Email, false);
            var LPVM2 = new ListPersonViewModel(contacts2.Name, contacts2.Email, false);

            ListOfPeople.Add(LPVM1);
            ListOfPeople.Add(LPVM2);

            return ListOfPeople
                .OrderBy(o => o.Name)
                .Select(o=> new ListPersonViewModel
                {
                    Name = o.Name,
                    Email = o.Email,
                    ShowAsHighlighted = o.Email.Split('@').Last() == "acme.com"
                })
                .ToArray();
        }

        public void AddPerson(CreatePersonViewModel viewModel)
        {
            var person = new Person();
            person.Name = viewModel.Name;
            person.Email = viewModel.Email;

            ListOfPeople.Add(person);
        }
    }
}
