using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFKH.Controllers
{
    public class SchedulerController : Controller
    {
        // GET: Scheduler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {
              

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}