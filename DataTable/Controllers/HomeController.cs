using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTable.Controllers
{
    public class HomeController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        // GET: Home
        
        public ActionResult Index()
        {

            return View(db.Products.ToList());
        }
    }
}