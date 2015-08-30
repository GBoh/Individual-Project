using Individual_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Individual_project.Controllers
{
    public class InputDataController : Controller
    {
        private Repository _repo = new Repository();

        // GET: InputData
        public ActionResult Index()
        {

            var Events = new List<Event>();

            Events = _repo.GetEvents();
            
            var vm = new MFTFormViewModel();
            
            return View(vm);
            
        }

        // GET: InputData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InputData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InputData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InputData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InputData/Edit/5
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

        // GET: InputData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InputData/Delete/5
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
