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
            
            Models.Achievements[] achievements = new Models.Achievements[2] {achievement, achievement1 }; 
            Random rand = new Random();

            achievement1.AchieveType = Models.AchieveType.Educator;

            for (int i = 0; i < 10; i++)
            {
                int index = rand.Next(0, 2);
                giveAchievement.GiveAchievments(achievements[index], child);
                giveAchievement.GiveAchievments(achievements[index], educator);
            }

            ViewBag.EducatorStatus = educator.Status;
            ViewBag.EducatorAchieveCount = educator.Achievements.Count;
            ViewBag.ChildAchieveCount = child.Achievements.Count;

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