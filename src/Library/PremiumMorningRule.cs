using System;

namespace Ucu.Poo.Ocp
{
    public class PremiumMorningRule : IAccessRule
    {
        public bool CheckAccess(Membership membership, DateTime date, int hour)
        {
            DayOfWeek day = date.DayOfWeek;
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Friday)
            {
                if (hour >= 6 && hour < 10)
                {
                    return membership == Membership.Premium;
                }
            }
            return false;
        }
    }
}