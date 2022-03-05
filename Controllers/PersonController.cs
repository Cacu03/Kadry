using Kadry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kadry.Controllers
{
    public class PersonController : BaseController
    {
        
        // GET: Person
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Lista()
        {
            var model = _db.Persons.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Person person)
        {
            if(ModelState.IsValid)
            {
                _db.Persons.Add(person);
                _db.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(person);
        }

        public ActionResult Edit(int id)
        {
            var model = _db.Persons.Find(id);
            if (model != null)
            {
                return View(model);
            }
            return RedirectToAction("Lista");
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            
                _db.Entry(person).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Lista");
            
        }
    }
}