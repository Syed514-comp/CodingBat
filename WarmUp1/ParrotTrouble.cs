using System;

namespace WarmUp1
{
    public class ParrotTrouble
    {
        public static bool Solve(bool talking, int hour)
        {
            return talking && (hour < 7 || hour > 20);
        }
    }
}
