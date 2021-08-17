using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PROG123.DAL;
using PROG123.Models;

namespace PROG123.Controllers
{
    public class LinController : Controller
    {
        private readonly ILogger<LinController> _logger;
        private readonly IConfiguration _configuration;

        public LinController(ILogger<LinController> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LogInCredentialsModel loginCredential)
        {
            DALPerson dp = new DALPerson(_configuration);
            PersonModel pm = dp.CheckLogInCredentials(loginCredential);
            string PersonID = pm.PersonID;
            HttpContext.Session.SetString("PersonID", PersonID);
            if (pm == null)
            {
                ViewBag.LoginMessage = "Log in failed";
            }
            else
            {
                ViewBag.UserFirstName = pm.FName;
            }

            return View("Index");
        }

        public IActionResult ViewCart()
        {
            return View("Cart");
        }

        public IActionResult EnterNewProduct()
        {
            string personID = HttpContext.Session.GetString("PersonID");
            if (personID == null)
            {
                ViewBag.LoginMessage = "User is not logged in";
                return View("Index");
            }
            else
            {
                return View("EnterNewProduct");
            }
        }

        public IActionResult AddProductToDB(ProductModel productModel)
        {
            string personID = HttpContext.Session.GetString("PersonID");
            if (personID == null)
            {
                ViewBag.LoginMessage = "User is not logged in";
                return View("Index");
            }
            else
            {
                DALProducts dp = new DALProducts(_configuration);
                string PID = dp.AddNewProduc(productModel);

                return View("AddProductToDB", productModel);
            }
        }

        public IActionResult ListAllProducts()
        {
            string personID = HttpContext.Session.GetString("PersonID");
            if (personID == null)
            {
                ViewBag.LoginMessage = "User is not logged in";
                return View("Index");
            }
            else
            {
                DALProducts dp = new DALProducts(_configuration);
                LinkedList<ProductModel> products = dp.GetAllProducts();
                return View("ListAllProduct", products);
            }

        }

        public IActionResult OneClickBuy(string PID)
        {
            string personID = HttpContext.Session.GetString("PersonID");
            if (personID == null)
            {
                ViewBag.LoginMessage = "User is not logged in";
                return View("Index");
            }
            else
            {
                DALSalesTransaction dst = new DALSalesTransaction(_configuration);
                PurchaseModel pm = dst.OneClickBuy(PID, personID, 1);
                return View("OneClickBuy", pm);
            }
        }
    }
}
