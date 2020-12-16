using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AchievementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.Educator educator = new Models.Educator(Models.Human.Educator);
            Models.Child child = new Models.Child(Models.Human.Child);

            Random rand = new Random();
            int achievPeriod = rand.Next(35, 60); //Ачивки за период

            Models.GiveAchievement giveAchievement = new Models.GiveAchievement();
            giveAchievement.GiveAchievments(achievPeriod, educator.educatorAchievments, child.childAchievments, educator.educator, child.child);

            ViewBag.Period = achievPeriod;
            ViewBag.EducatorStat = educator.Status;
            ViewBag.EducatorAchieve = educator.educatorAchievments.Count;
            ViewBag.ChildAchieve = child.childAchievments.Count;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}