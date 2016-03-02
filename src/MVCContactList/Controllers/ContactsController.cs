using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVCContactList.Models;
using MVCContactList.ViewModels;

namespace MVCContactList.Controllers
{
    public class ContactsController : Controller
    {
        //public IActionResult Index()
        //{
        //    var dataManager = new DataManager();
        //    var model = dataManager.GetAllContacts();
            // Ändra till ListAllContacts
            //return View(model);
        }

        public IActionResult Create(CreatePersonViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var dataManager = new DataManager();
            //dataManager.AddPerson(viewModel);

            return RedirectToAction(nameof(ContactsController.Index));
        }
    }
}
