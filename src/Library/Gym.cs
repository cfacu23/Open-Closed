using System;
using System.Collections.Generic;

namespace Ucu.Poo.Ocp
{
    public class Gym
    {
        private List<IAccessRule> rules;

        public Gym()
        {
            this.rules = new List<IAccessRule>();
            this.rules.Add(new PremiumMorningRule());
            this.rules.Add(new DaytimeRule());
            this.rules.Add(new EveningRule());
            this.rules.Add(new SaturdayRule());
            this.rules.Add(new HolidayRule());
        }

        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            foreach (IAccessRule rule in this.rules)
            {
                if (rule.CheckAccess(membership, date, hour))
                {
                    return true;
                }
            }
            return false;
        }
    }
}