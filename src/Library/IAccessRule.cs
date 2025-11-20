using System;

namespace Ucu.Poo.Ocp
{
    public interface IAccessRule
    {
        bool CheckAccess(Membership membership, DateTime date, int hour);
    }
}