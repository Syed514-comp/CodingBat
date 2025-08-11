//public class Solutio
//{
//    public string LongestPalindrome(string s)
//    {
//        if (string.IsNullOrEmpty(s) || s.Length < 1)
//        {
//            return "";
//        }
//        int start = 0, end = 0;

//        for (int i = 0; i< s.Length; i++)
//        {
//            int len1 = ExpandFromCenter(s, i, i);
//        }
//    }

//    private int ExpandFromCenter(string s, int left, int right)
//    {
//        while (left >= 0 && right < s.Length && s[left] == s[right]) {
//            left--;
//            right++;
//    }
//}