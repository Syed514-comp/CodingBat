using System;
using System.Collections.Generic;

public class Program
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (map.ContainsKey(diff))
            {
                return new int[] { map[diff], i };
            }

            // Always store the number and its index
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        return new int[] { }; // No solution found
    }
}
    //public static void Main()
    //{
    //    // Test Case 1
    //    int[] result1 = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
    //    Console.WriteLine("Test Case 1: " + FormatResult(result1)); // Expected: [0, 1]

    //    // Test Case 2
    //    int[] result2 = TwoSum(new int[] { 3, 2, 4 }, 6);
    //    Console.WriteLine("Test Case 2: " + FormatResult(result2)); // Expected: [1, 2]

    //    // Test Case 3
    //    int[] result3 = TwoSum(new int[] { 3, 3 }, 6);
    //    Console.WriteLine("Test Case 3: " + FormatResult(result3)); // Expected: [0, 1]

    //    // Test Case 4: No solution
    //    int[] result4 = TwoSum(new int[] { 1, 2, 3 }, 7);
    //    Console.WriteLine("Test Case 4: " + FormatResult(result4)); // Expected: No solution found
    //}

    //private static string FormatResult(int[] result)
    //{
    //    if (result.Length == 0) return "No solution found";
    //    return "[" + string.Join(", ", result) + "]";
    //}

