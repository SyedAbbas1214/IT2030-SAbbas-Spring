﻿using EventPlanner.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventPlanner.Controllers
{
    public class UsersController : Controller
    {
        [Authorize]
        
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;

                ViewBag.displayMenu = "No";

                if (isPromoterUser())
                {
                    return RedirectToAction("Index", "Promoter");
                }
                else
                {
                    return RedirectToAction("Index", "Attendee");
                }
            }
            else
            {
                ViewBag.Name = "Not Logged IN";
            }
            return View();

        }

        public Boolean isPromoterUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Promoter")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}