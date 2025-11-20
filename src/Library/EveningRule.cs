using System;

namespace Ucu.Poo.Ocp
{
    public class EveningRule : IAccessRule
    {
        public bool CheckAccess(Membership membership, DateTime date, int hour)
        {
            DayOfWeek day = date.DayOfWeek;
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Friday)
            {
                if (hour >= 17 && hour < 21)
                {
                    return membership == Membership.Basic || membership == Membership.Premium;
                }
            }
            return false;
        }
    }
}