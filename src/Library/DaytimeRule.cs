using System;

namespace Ucu.Poo.Ocp
{
    public class DaytimeRule : IAccessRule
    {
        public bool CheckAccess(Membership membership, DateTime date, int hour)
        {
            DayOfWeek day = date.DayOfWeek;
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Friday)
            {
                if (hour >= 10 && hour < 17)
                {
                    return true;
                }
            }
            return false;
        }
    }
}