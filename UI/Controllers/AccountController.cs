using DomainModels.ViewModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class AccountController : Controller
    {
        IUnitOfWork uow;

        public AccountController()
        {
            uow = new UnitOfwork();
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                UserViewModel user = uow.AuthenticateRepository.ValidateUser(model);
                if(user!=null)
                {
                    if(user.Roles.Contains("Admin"))
                    {
                        return RedirectToAction("Home", "Index", new { area = "Admin" });
                    }

                    else
                    {
                        return RedirectToAction("Home", "Index", new { area = "User" });
                    }
                }
            }
            return View();
        }
    }
}