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
        // GET: InputData
        public ActionResult Index()
        {
            //MFTFormSubmission model = new MFTFormSubmission();
            //model.Events = new List<Event>();
            //model.Events.Add(new Event { EventType = "IT - Individual Therapy", Id = 0});
            //model.Events.Add(new Event { EventType = "GT - Group Therapy", Id = 1});
            //model.Events.Add(new Event { EventType = "FT - Family Thearapy", Id = 2});
            //model.Events.Add(new Event { EventType = "ITS - Individual Thearapy Supervised", Id = 3});

            //model.GroupLocations = new List<Group>();
            //model.GroupLocations.Add(new Group { GroupLocation = "Practicum Team", Id = 0 });
            //model.GroupLocations.Add(new Group { GroupLocation = "Off-Site Team", Id = 1 });

            //model.ObservableData = new List<ObservableData>();
            //model.ObservableData.Add(new ObservableData { ObservableDataType = "Supervisor in Room", Id = 0 });
            //model.ObservableData.Add(new ObservableData { ObservableDataType = "Used Recording", Id = 1 });

            //model.Supervisors = new List<Supervisor>();
            //model.Supervisors.Add(new Supervisor { SupervisorType = "AAMFT Approved Supervisor", Id = 0 });
            //model.Supervisors.Add(new Supervisor { SupervisorType = "State LMFT Approved Supervisor", Id = 1 });
            //model.Supervisors.Add(new Supervisor { SupervisorType = "Non-Approved Supervisor", Id = 2 });
            return View();
            
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
