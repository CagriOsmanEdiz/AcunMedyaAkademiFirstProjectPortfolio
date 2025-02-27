﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio.Models;

namespace AcunMedyaPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        AcunMedyaEntities1 db = new AcunMedyaEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
          return PartialView(); 
        }
        public PartialViewResult PartialFeature()
        {
            var values= db.TblFeature.ToList(); 
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var SkillCount = db.TblSkill.ToList().Count;
            ViewBag.SkillCount= SkillCount;
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);

        }
        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TBlTestimonial.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public ActionResult PartialContact()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact y)
        {
            if (ModelState.IsValid)
            {
                db.TblContact.Add(y);
                db.SaveChanges();

                ViewBag.RedirectUrl = Url.Action("Index", "Default");
            }
            return PartialView();
        }
        public ActionResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            var values = db.TblFooter.ToList();

            return PartialView(values);

        }
        public PartialViewResult PartialHobby()
        {
            var values = db.TblHobby.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAdress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }

    }

}