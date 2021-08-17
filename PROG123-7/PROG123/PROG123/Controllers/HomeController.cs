using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PROG123.DAL;
using PROG123.Models;
using PROG123.utils;


namespace PROG123.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // this is for testing purpuse only.
            // DatabaseHelper dbh = new DatabaseHelper(_configuration);
            // ConnStatusModel status = dbh.GetConnectionStringAndConnectionStatus();
            // ViewBag.ConnStr = status.ConnStr;
            // ViewBag.DBStatus = status.DBConnectionStatus;
            // ViewBag.Exception = status.Exception;

            return View();
        }

        public IActionResult Page2(PersonModel personModel)
        {
            
            DALPerson dp = new DALPerson(_configuration);
            string PersonID = dp.AddPerson(personModel);
            HttpContext.Session.SetString("PersonID", PersonID);

            return View(personModel);
        }

        // add your actions here 
        
        public IActionResult EditMyInfo()
        {
            string personID = HttpContext.Session.GetString("PersonID");
            DALPerson dp = new DALPerson(_configuration);
            PersonModel pm = dp.getPerson(personID);

            return View(pm);
        }
        public IActionResult UpdatePersonTable(PersonModel person)
        {
            string personID = HttpContext.Session.GetString("PersonID");
            DALPerson dp = new DALPerson(_configuration);
            PersonModel pm = dp.getPerson(personID);
            person.PersonID = pm.PersonID;
            dp.UpdatePerson(person);

            return View("page2", person);
        }

        public IActionResult DeletePerson()
        {
            string personID = HttpContext.Session.GetString("PersonID");
            DALPerson dp = new DALPerson(_configuration);
            dp.DeletePerson(personID);

            return View("DeletePerson");
        }
    }
}
