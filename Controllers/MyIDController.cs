using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubMVCProject.Controllers
{
    public class MyIDController : Controller
    {
        // GET: MyID
        public ActionResult Index()
        {
            return View();
        }

        // Action Method
        public ActionResult DescribeMySelf()
        {
            return View();
        }
    }
}