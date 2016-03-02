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

        static DataManager()
        {
            #region Skapar två hårdkodade kontakter
            var contacts1 = new Person("Mikael", "mikael.brunnberg@gmail.com");
            var contacts2 = new Person("Sebastian", "sebastian.udden@gmail.com");
            var contacts3 = new Person("Pontus", "pontus@acme.com");

            var LPVM1 = new Person(contacts1.Name, contacts2.Email);
            var LPVM2 = new Person(contacts2.Name, contacts2.Email);
            var LPVM3 = new Person(contacts3.Name, contacts2.Email);

            ListOfPeople.Add(LPVM1);
            ListOfPeople.Add(LPVM2);
            ListOfPeople.Add(LPVM3);
            #endregion
        }
        public ListPersonViewModel[] ListPeople()
        {
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
