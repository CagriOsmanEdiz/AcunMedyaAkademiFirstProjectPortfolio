using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio.Models;

namespace AcunMedyaPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        // GET: Feature
        AcunMedyaEntities1 db = new AcunMedyaEntities1();
        public ActionResult Index()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(TblFeature p)
        {
            db.TblFeature.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFeature(int id )
        {
            var value= db.TblFeature.Find(id);
            db.TblFeature.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(TblFeature p)
        {
            var value = db.TblFeature.Find(p.FeatureID);
            value.FeatureTitle = p.FeatureTitle;
            value.FeatureSubtitle = p.FeatureSubtitle;
            value.FeatureImageUrl = p.FeatureImageUrl;
            //  value.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }   
}


//Burdaki methodları Catgeory ,Service,Contact için oluştur viewlerini oluştur 
//açtığım vievdkei gibi sidebarda doğru urllerini ver yeterli :) ondan sonra size bir daha yazayım mı hocam peki yoksa direkt githuba atayım mı
//yaz tekrar bakalım sonra githuba atarsın tamam hocam teşekkür ederim :)
//ric ederim :)