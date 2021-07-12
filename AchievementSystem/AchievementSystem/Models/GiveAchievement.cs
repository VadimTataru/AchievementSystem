using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchievementSystem.Models
{
    public class GiveAchievement : Achievements
    {
        public void GiveAchievments(Achievements achievements, Human human)
        {
            if(achievements.AchieveType == AchieveType.Child && human is Child child)
            {
                child.Achievements.Add(achievements);
            }

            if (achievements.AchieveType == AchieveType.Educator && human is Educator educator)
            {
                educator.Achievements.Add(achievements);
            }
        }
    }
}