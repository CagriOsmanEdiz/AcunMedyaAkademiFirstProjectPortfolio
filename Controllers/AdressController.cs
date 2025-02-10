﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio.Models;

namespace AcunMedyaPortfolio.Controllers
{
    public class AdressController : Controller
    {
        // GET: Adress
        AcunMedyaEntities1 db = new AcunMedyaEntities1();

        public ActionResult Index()
        {
            var values = db.TblAdress.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAdress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAdress(TblAdress p)
        {
            db.TblAdress.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAdress(int id)
        {
            var value = db.TblAdress.Find(id);
            db.TblAdress.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult UpdateAdress(int id)
        {
            var value = db.TblAdress.Find(id);
            return View(value);
        }
   

    }
}