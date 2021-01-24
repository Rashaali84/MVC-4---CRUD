using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        //initializa 
        EShopsEntities _DbContext;
        public HomeController()
        {
            _DbContext = new EShopsEntities();

        }
        public void Dispose()
        {
            _DbContext.Dispose();

        }
        public ActionResult Index()
        {
            return View();
        }

       
        
      
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}