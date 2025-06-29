
//Modify and return the given map as follows: if the key "a" has a value, set the key "b" to have that same value. In all cases remove the key "c", leaving the rest of the map unchanged.


//mapShare({"a": "aaa", "b": "bbb", "c": "ccc"}) → { "a": "aaa", "b": "aaa"}
//mapShare({ "b": "xyz", "c": "ccc"}) → { "b": "xyz"}
//mapShare({ "a": "aaa", "c": "meh", "d": "hi"}) → { "a": "aaa", "b": "aaa", "d": "hi"}

namespace Map_1;

public class MapShare
{
    public static Dictionary<string, string> Solve(Dictionary<string, string> dict){
        if (dict.ContainsKey("a"))
        {
            dict["b"] = dict["a"];
        }

        dict.Remove("c");
        return dict;
}
}

