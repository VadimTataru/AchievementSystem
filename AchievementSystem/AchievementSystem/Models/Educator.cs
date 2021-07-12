using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AchievementSystem.Models
{
    public class Educator : Human
    {
        public string Status
        {
            get
            {
                if (Achievements.Count < 2)
                {
                    status = "бронзовый статус";
                }
                else if (Achievements.Count < 5)
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
        
        string status;
    }
}