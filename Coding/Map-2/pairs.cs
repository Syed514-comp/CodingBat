
//Given an array of non-empty strings, create and return a Map<String, String> as follows: for each string add its first character as a key with its last character as the value.


//pairs(["code", "bug"]) → { "b": "g", "c": "e"}
//pairs(["man", "moon", "main"]) → { "m": "n"}
//pairs(["man", "moon", "good", "night"]) → { "g": "d", "m": "n", "n": "t"}
namespace Map_2;

public class Pairs
{
    public static Dictionary<string, string > Solve(String[] strings)
    {
        var result = new Dictionary<string, string>();

        foreach (var s in strings)
        {
            var first = s[0].ToString();
            var last = s[s.Length - 1].ToString();
            if (!result.ContainsKey(first))
            {
                result[first] = last;
            }
        } return result;
    }
}
