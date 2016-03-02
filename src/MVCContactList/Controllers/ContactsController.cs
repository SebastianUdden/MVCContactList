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
        public IActionResult Index()
        {
            var dataManager = new DataManager();
            var model = dataManager.ListPeople();
            // Ändra till ListAllContacts
            return View(model);
        }

        public IActionResult Create(CreatePersonViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            try
            {
                var dataManager = new DataManager();
                dataManager.AddPerson(viewModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(CreatePersonViewModel.Name), "Fel!");
                return View();
            }

            return RedirectToAction(nameof(ContactsController.Index));
        }
    }
}
