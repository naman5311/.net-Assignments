using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnCRUDAssignment.Repositories;
using HandsOnCRUDAssignment.Entities;

namespace HandsOnCRUDAssignment.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository _repo = new CustomerRepository();
        // GET: CustomerController
        [Route("GetAll")]
        public ActionResult Index()
        {
            return View(_repo.GetCustomers());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {

            return View(_repo.GetCustomersById(id));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Add(c);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(string id)
        {
            return View(_repo.GetCustomersById(id));
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Customer c)
        {
            try
            {
                _repo.Update(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(string id)
        {
            return View(_repo.GetCustomersById(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Customer c)
        {
            try
            {
                _repo.Delete(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
