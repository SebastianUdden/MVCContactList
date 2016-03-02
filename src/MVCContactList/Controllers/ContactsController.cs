using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVCContactList.Models;

namespace MVCContactList.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            var dataManager = new DataManager();
            var model = dataManager.GetAllContacts();
            return View(model);
        }

        //public IActionResult Create()
        //{
        //    var dataManager = new DataManager();
        //    var model = dataManager.GetYearInfo(id);
        //    return View(model);
        //}
    }
}
