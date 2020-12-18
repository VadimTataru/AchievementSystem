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
            Models.Educator educator = new Models.Educator();
            Models.Child child = new Models.Child();
            Models.GiveAchievement giveAchievement = new Models.GiveAchievement();

            Models.Achievements achievement = new Models.Achievements();
            Models.Achievements achievement1 = new Models.Achievements();
            achievement1.AchieveType = Models.AchieveType.Educator;

            Models.Achievements[] achievements = new Models.Achievements[2] {achievement, achievement1 }; 
            Random rand = new Random();

            for(int i = 0; i < 10; i++)
            {
                int index = rand.Next(0, 2);
                giveAchievement.GiveAchievments(educator, achievements[index]);
                giveAchievement.GiveAchievments(child, achievements[index]);
            }

            ViewBag.Period = educator.educatorAchievments.Count + child.childAchievments.Count;
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