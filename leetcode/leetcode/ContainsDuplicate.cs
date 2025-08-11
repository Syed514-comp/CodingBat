public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> visited = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (visited.Contains(nums[i]))
            { return true; }
            else { visited.Add(nums[i]); }
            
        }
        return false;
    }
}