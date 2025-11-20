using System;

namespace Ucu.Poo.Ocp
{
    public class HolidayRule : IAccessRule
    {
        public bool CheckAccess(Membership membership, DateTime date, int hour)
        {
            if (Calendar.IsHoliday(date))
            {
                if (hour >= 10 && hour < 18)
                {
                    return membership == Membership.Premium;
                }
            }
            return false;
        }
    }
}