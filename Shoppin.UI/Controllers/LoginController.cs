using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shopping.BLL.DTOs;
using Shoppin.UI.Models.view;
using static Shopping.BLL.BussinessManager;

namespace Shoppin.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel m)
        {
            try
            {
               
            }
            catch (Exception)
            {

               
            }
            return View();
        }

    }
}