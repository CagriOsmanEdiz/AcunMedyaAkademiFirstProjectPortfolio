using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio.Models;

namespace AcunMedyaPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
       AcunMedyaEntities1 db=new AcunMedyaEntities1();
        public ActionResult Index()
        {
          var values=db.TBlTestimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
        return View();
        
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TBlTestimonial p)
        {
            db.TBlTestimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteTestimonial(int id) {
            var value = db.TBlTestimonial.Find(id);
            db.TBlTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
    }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id )
        {
            var value=db.TBlTestimonial.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TBlTestimonial p)
        {
            var value = db.TBlTestimonial.Find(p.TestimonialId);
            value.TestimonialDescription = p.TestimonialDescription;
            value.TestimonialmageUrl=p.TestimonialmageUrl;
            value.TestimonialName = p.TestimonialName;
            value.TestimonialTitle = p.TestimonialTitle;
             value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");   
        }

    }



}