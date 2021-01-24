using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class EshopController : Controller
    {
        EShopsEntities _DbContext;
        public EshopController()
        {
            _DbContext = new EShopsEntities();

        }
        public void Dispose()
        {
            _DbContext.Dispose();

        }
        public ActionResult About()
        {
            List<Eshop> listShops;
            using (_DbContext)
            {
                listShops = _DbContext.Eshops.ToList();

            }


            return View(listShops);
        }
        // GET: Eshop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {
            
            var eshopTypes = _DbContext.EshopTypes.ToList();
            var newViewModel = new NewShopShopTypesViewModel
            {
                EshopTypeList = eshopTypes ,
                Eshop = null

            };
            return View(newViewModel);
        }
        public ActionResult Edit(int id)
        {
            // in the list of eshops
            var eShop = _DbContext.Eshops.SingleOrDefault(sh => sh.EshopId == id);
            if (eShop == null)
                return HttpNotFound();
            var eShopViewModel = new NewShopShopTypesViewModel
            {
                Eshop = eShop,
                EshopTypeList = _DbContext.EshopTypes.ToList()
            };
            return View("New",eShopViewModel );
            
        }
        public ActionResult Details(int id)
        {
            var eShop = _DbContext.Eshops.SingleOrDefault(sh => sh.EshopId == id);
            return View(eShop);

        }
        
        public ActionResult Delete(int id)
        {
            Eshop eshopToDelete=_DbContext.Eshops.Where(sh => sh.EshopId == id).SingleOrDefault();
            _DbContext.Eshops.Remove(eshopToDelete);
            _DbContext.SaveChanges();
            return RedirectToAction("About", "Eshop");
        }
        [HttpPost]
        public ActionResult Create(NewShopShopTypesViewModel newShop)
        {
            //check if already exist update
             newShop.Eshop.CreatedDate = DateTime.Now;
            _DbContext.Eshops.Add(newShop.Eshop);
            _DbContext.SaveChanges();
            return RedirectToAction("About","Eshop");

        }
    }
}