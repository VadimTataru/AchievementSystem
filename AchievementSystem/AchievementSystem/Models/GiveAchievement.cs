using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchievementSystem.Models
{
    public class GiveAchievement : Achievements
    {
        public void GiveAchievments(object obj, Achievements achievements)
        {
            if(obj is Child child && achievements.AchieveType == AchieveType.Child)
            {
                child.childAchievments.Add(achievements);
            }

            if(obj is Educator educator && achievements.AchieveType == AchieveType.Educator)
            {
                educator.educatorAchievments.Add(achievements);
            }
        }
    }
}