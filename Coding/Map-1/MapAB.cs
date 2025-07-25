﻿
//Modify and return the given map as follows: for this problem the map may or may not contain the "a" and "b" keys.If both keys are present, append their 2 string values together and store the result under the key "ab".


//mapAB({ "a": "Hi", "b": "There"}) → { "a": "Hi", "ab": "HiThere", "b": "There"}
//mapAB({ "a": "Hi"}) → { "a": "Hi"}
//mapAB({ "b": "There"}) → { "b": "There"}

namespace Map_1;

public class MapAB
{
    public static Dictionary<string, string> Solve(Dictionary<string, string> dict)
    {
        if(dict.ContainsKey("a") && dict.ContainsKey("b")){
            dict["ab"] = dict["a"] + dict["b"];
        } return dict;
    }
}


