using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Cccc.Models;
using Cccc.ViewModels;

namespace Cccc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowProducts()
        {
            List<VmProducts> vm;

            using (var db = new DataContext())
            {
                var data = db.Products;
                vm = data.Select(x => new VmProducts()
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    QuantityPerUnit = x.QuantityPerUnit,
                    UnitPrice = x.UnitPrice
                }).ToList();
            }

            return View(vm);
        }

        public ActionResult ShowProductDetails(Guid id)
        {
            VmProducts vm;
            using (var db = new DataContext())
            {
                var x = db.Products.Find(id);
                vm = new VmProducts()
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    QuantityPerUnit = x.QuantityPerUnit,
                    UnitPrice = x.UnitPrice
                };
            }

            return View(vm);
        }

        [HttpPost]
        public ActionResult SaveProductDetails(VmProducts vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (var db = new DataContext())
                    {
                        var x = db.Products.Find(vm.ProductID);
                        x.Updatestuff(vm.ProductName, vm.QuantityPerUnit, vm.UnitPrice);
                        db.SaveChanges();
                    }

                    return RedirectToAction("ShowProducts");                    
                }
                catch (Exception e)
                {
                    return RedirectToAction("ShowProductDetails", new {id = vm.ProductID});
                }                               
            }

            return RedirectToAction("ShowProductDetails", new { id = vm.ProductID });
        }
    }
}