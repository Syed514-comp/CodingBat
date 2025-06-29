//Modify and return the given map as follows: if exactly one of the keys "a" or "b" has a value in the map (but not both),
//set the other to have that same value in the map.


//mapAB3({"a": "aaa", "c": "cake"}) → { "a": "aaa", "b": "aaa", "c": "cake"}
//mapAB3({ "b": "bbb", "c": "cake"}) → { "a": "bbb", "b": "bbb", "c": "cake"}
//mapAB3({ "a": "aaa", "b": "bbb", "c": "cake"}) → { "a": "aaa", "b": "bbb", "c": "cake"}

namespace Map_1;

public class MapAB3
{
    public static Dictionary<string, string> Solve(Dictionary<string, string> dict)
    {
        if (dict.ContainsKey("a") && !dict.ContainsKey("b"))
        {
            dict["b"] = dict["a"];
        }
        else if (!dict.ContainsKey("a") && dict.ContainsKey("b"))
        {
            dict["a"] = dict["b"];
        }

        return dict;
    }
}
