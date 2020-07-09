using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnAssignment.Models;

namespace HandsOnAssignment.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> Plist = new List<Product>()
        {
            new Product() { Pid="P001",Pname="Chair",Price=600,Stock=200 }
        };
        [Route("GetAllData")]
        public IActionResult Index()
        {
            return View(Plist);
        }
        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Route("Create")]
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                Plist.Add(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
