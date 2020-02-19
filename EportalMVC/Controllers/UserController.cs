using System;
using System.Web.Mvc;

namespace EportalMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
		
            return View();
        }
		public ActionResult SignUp()
		{
			return View();
		}
		public ActionResult Display()
		{
			return View();
		}
	}
}