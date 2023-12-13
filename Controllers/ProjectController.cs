using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Dal;
using WebApplication2.Interface;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProjectController : Controller
    {
        UserInterface ui = new UserClass();
        dropdownInterface drp = new dropdown();
        public IActionResult Index()
        {
            ViewBag.Countries = new List<String>
            {
            "INDIA",
            "USA",
            "UK",
            "UAE"
            };
            ViewData["project"] = "Example of View Data";

            TempData["project"] = "Example of Temp Data";
            return View();
        }
        public IActionResult Index1()
        {
            var client = drp.GetClientList();
            ViewBag.cli = new SelectList(client, "projectClient", "projectClient");
            var z = ui.getprojectdetails();
            return View(z);
        }

        public JsonResult insert(user objmodel)
        {
            return Json(ui.adduser(objmodel));
        }
        public JsonResult update(user objmodel)
        {
            return Json(drp.updateuser(objmodel));
        }

        public JsonResult deleteProject(int id)
        {
            return Json(drp.deleteProject(id));
        }

        public JsonResult editProject(int id)
        {
           return Json(drp.editProject(id));
        }

        public IActionResult ProjectList()
        {
            
            return PartialView("ProjectList");
            
        }
        public IActionResult item()
        {
            return View();
        }



    }
}
