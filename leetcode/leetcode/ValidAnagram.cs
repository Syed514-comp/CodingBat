using System;
using System.Collections.Generic;

public class Soln
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }

        foreach (char c in t)
        {
            if (!map.ContainsKey(c))
                return false;

            map[c]--;
        }

        foreach (var pair in map)
        {
            if (pair.Value != 0)
                return false;
        }

        return true;
    }

    // Main method with test cases
    public static void Main()
    {
        Soln solution = new Soln();

        // Test cases
        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // true
        Console.WriteLine(solution.IsAnagram("rat", "car"));         // false
        Console.WriteLine(solution.IsAnagram("aacc", "ccac"));       // false
        Console.WriteLine(solution.IsAnagram("listen", "silent"));   // true
        Console.WriteLine(solution.IsAnagram("abcd", "dcba"));       // true
        Console.WriteLine(solution.IsAnagram("hello", "olleh"));     // true
        Console.WriteLine(solution.IsAnagram("ab", "a"));            // false
    }
}
