using System;

namespace Ucu.Poo.Ocp
{
    public class SaturdayRule : IAccessRule
    {
        public bool CheckAccess(Membership membership, DateTime date, int hour)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                if (hour >= 8 && hour < 20)
                {
                    return membership == Membership.Basic || membership == Membership.Premium;
                }
            }
            return false;
        }
    }
}