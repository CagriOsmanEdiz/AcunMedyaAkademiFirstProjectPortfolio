﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio.Models;

namespace AcunMedyaPortfolio.Controllers
{
    public class HobbyController : Controller
    {
        // GET: Hobby
        AcunMedyaEntities1 db = new AcunMedyaEntities1();
        public ActionResult Index()
        {
            var values = db.TblHobby.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateHobby()
        {//HATAYI GÖSSTERİR MİSİNN
            return View();
        }
        [HttpPost]
        public ActionResult CreateHobby(TblHobby p)
        {
            db.TblHobby.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHobby(int id)
        {
            var value = db.TblHobby.Find(id);
            db.TblHobby.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateHobby(int id)
        {
            var value = db.TblHobby.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateHobby(TblHobby p)
        {
            var value = db.TblHobby.Find(p.HobbyID);
            value.IconUrl = p.IconUrl;
            value.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}