
//The classic word-count algorithm: given an array of strings, return a Map<String, Integer> with a key for each different string, with the value the number of times that string appears in the array.


//wordCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
//wordCount(["c", "b", "a"]) → {"a": 1, "b": 1, "c": 1}
//wordCount(["c", "c", "c", "c"]) → {"c": 4}
//The classic word-count algorithm: given an array of strings, return a Map<String, Integer> with a key for each different string, with the value the number of times that string appears in the array.


//wordCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
//wordCount(["c", "b", "a"]) → {"a": 1, "b": 1, "c": 1}
//wordCount(["c", "c", "c", "c"]) → {"c": 4}

namespace Map_2;

public class WordCount
{
    public static Dictionary<string, int> Solve(String[] strings)
    {
        var result = new Dictionary<string, int>();
        var start = 1;
        foreach (var s in strings)
        {
            if (!result.ContainsKey(s))
            {
                result[s] = start;
            } else
            {
                result[s] = start + 1;
            }
        }
        return result;
    }
}


