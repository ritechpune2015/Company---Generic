using Company.Core;
using Company.Infra.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Web.Controllers
{
    public class CustController : Controller
    {
        // GET: Cust
        CustomerRepo crepo;
        public CustController()
        {
            this.crepo = new CustomerRepo();
        }
        public ActionResult Index()
        {
            return View(this.crepo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer rec)
        {
            if (ModelState.IsValid)
            {
                this.crepo.Add(rec);
                return RedirectToAction("Index");
            }

            return View(rec);
        }
    }
}