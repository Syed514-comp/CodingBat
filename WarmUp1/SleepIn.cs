using System;

namespace WarmUp1
{
    public class SleepIn
    {
        public static bool Solve(bool weekday, bool vacation)
        {
            return !weekday || vacation;
        }
    }
}
