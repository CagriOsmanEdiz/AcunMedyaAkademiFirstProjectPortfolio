using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio.Models;

namespace AcunMedyaPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        AcunMedyaEntities1 db = new AcunMedyaEntities1();
        // GET: Statistic
        public ActionResult Index()
        {

            ViewBag.CategoryCount = db.TblCategory.Count();
            ViewBag.ProjectCount = db.TblProject.Count();
            ViewBag.SkillsCount = db.TblSkill.Count();
            ViewBag.SkillAvgValue = db.TblSkill.Average(x => x.Value);
            //ViewBag.LastSkillTitleName = db.getl.FirstOrDefault();  //burada modeli sildikten sonra tekrar eklediğinde store presüdürleri eklemedin sanırsam o yüzden burası çıkmıyor şu anlık yorum satırı kalsın :)
            ViewBag.mvcCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 4).Count();
            return View();
        }
    }
}