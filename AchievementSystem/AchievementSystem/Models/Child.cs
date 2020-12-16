using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchievementSystem.Models
{
    public class Child
    {
        public Human child;
        public List<int> childAchievments = new List<int>();

        public Child(Human human)
        {
            child = human;
        }
    }
}