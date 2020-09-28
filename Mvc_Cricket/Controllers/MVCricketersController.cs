using Mvc_Cricket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Cricket.Controllers
{
    public class MVCricketersController : Controller
    {
        CricketerDBContext1 db = new CricketerDBContext1();
        // GET: MVCricketers
        public ActionResult Index()
        {
            return View();
        }

        // GET: MVCricketers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MVCricketers/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: MVCricketers/Create
        [HttpPost]
        public ActionResult Create(Cricketer cricketer)
        {
            try
            {
                // TODO: Add insert logic here
                
                db.Cricketers.Add(cricketer);
                db.SaveChanges();
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: MVCricketers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MVCricketers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MVCricketers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MVCricketers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
