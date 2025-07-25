﻿//Given an int n, return the absolute difference between n and 21, except return double the absolute difference if n is over 21.


//diff21(19) → 2
//diff21(10) → 11
//diff21(21) → 0
namespace WarmUp1
{
    public class Diff21
    {
        public static int Solve(int n)
        {
            return n > 21 ? Math.Abs(2 * (n - 21)) : 21 - n;
        }
    }
}
