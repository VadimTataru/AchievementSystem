﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchievementSystem.Models
{
    public class Educator
    {
        public string Status
        {
            get
            {
                if (educatorAchievments.Count < 17)
                {
                    status = "бронзовый статус";
                }
                else if (educatorAchievments.Count < 26)
                {
                    status = "золотой статус";
                }
                else
                {
                    status = "платиновый статус";
                }
                return status;
            }
        }

        public Human educator;
        string status;
        public List<int> educatorAchievments = new List<int>();

        public Educator(Human human)
        {
            educator = human;
        }
    }
}