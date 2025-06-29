
//Modify and return the given map as follows: if the keys "a" and "b" have values that have different lengths, then set "c" to have the longer value. If the values exist and have the same length, change them both to the empty string in the map.


//mapAB4({"a": "aaa", "b": "bb", "c": "cake"}) → { "a": "aaa", "b": "bb", "c": "aaa"}
//mapAB4({ "a": "aa", "b": "bbb", "c": "cake"}) → { "a": "aa", "b": "bbb", "c": "bbb"}
//mapAB4({ "a": "aa", "b": "bbb"}) → { "a": "aa", "b": "bbb", "c": "bbb"}

namespace Map_1;

public class MapAB4
{
    public static Dictionary<string, string> Solve(Dictionary<string, string> dict)
    {
        if (dict.ContainsKey("a") && dict.ContainsKey("b"))
        {
            string aVal = dict["a"];
            string bVal = dict["b"];

            if (aVal.Length == bVal.Length)
            {
                dict["a"] = "";
                dict["b"] = "";
            }
            else if (aVal.Length > bVal.Length)
            {
                dict["c"] = aVal;
            }
            else
            {
                dict["c"] = bVal;
            }
        }

        return dict;
    }
}


