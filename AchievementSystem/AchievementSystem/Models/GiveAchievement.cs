using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchievementSystem.Models
{
    public class GiveAchievement
    {
        public void GiveAchievments(int period, List<int> arr1, List<int> arr2, Human human1, Human human2)
        {
            Random rand = new Random();
            for (int i = 0; i < period; i++)
            {
                int achieve = rand.Next(1, 3);

                if (achieve == (int)human1)
                {
                    arr1.Add(1);
                }

                if (achieve == (int)human2)
                {
                    arr2.Add(2);
                }
            }
        }
    }
}