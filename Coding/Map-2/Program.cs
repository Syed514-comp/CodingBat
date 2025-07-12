using System;
using System.Collections.Generic;
using System.Linq;
using Map_2;

public class Program
{
    static void PrintMap(Dictionary<string, object> map)
    {
        Console.Write("{");
        bool first = true;
        foreach (var kvp in map)
        {
            if (!first) Console.Write(", ");
            Console.Write($"{kvp.Key}: {kvp.Value}");
            first = false;
        }
        Console.WriteLine("}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("word0([\"a\", \"b\", \"a\", \"b\"]):");
        PrintMap(ConvertToObjectMap(Word0.Solve(new string[] { "a", "b", "a", "b" })));

        // Uncomment the following lines once you implement the corresponding classes

        Console.WriteLine("wordLen([\"a\", \"bb\", \"a\", \"bb\"]):");
        PrintMap(ConvertToObjectMap(WordLen.Solve(new string[] { "a", "bb", "a", "bb" })));

        Console.WriteLine("pairs([\"code\", \"bug\"]):");
        PrintMap(ConvertToObjectMap(Pairs.Solve(new string[] { "code", "bug" })));

        Console.WriteLine("wordCount([\"a\", \"b\", \"a\", \"c\", \"b\"]):");
        PrintMap(ConvertToObjectMap(WordCount.Solve(new string[] { "a", "b", "a", "c", "b" })));

        // Console.WriteLine("firstChar([\"salt\", \"tea\", \"soda\", \"toast\"]):");
        // PrintMap(ConvertToObjectMap(FirstChar.Solve(new string[] { "salt", "tea", "soda", "toast" })));

        // Console.WriteLine("wordAppend([\"a\", \"b\", \"a\"]):");
        // Console.WriteLine(WordAppend.Solve(new string[] { "a", "b", "a" }));

        // Console.WriteLine("wordMultiple([\"a\", \"b\", \"a\", \"c\", \"b\"]):");
        // PrintMap(ConvertToObjectMap(WordMultiple.Solve(new string[] { "a", "b", "a", "c", "b" })));

        // Console.WriteLine("allSwap([\"ab\", \"ac\"]):");
        // Console.WriteLine(string.Join(", ", AllSwap.Solve(new string[] { "ab", "ac" })));

        // Console.WriteLine("firstSwap([\"ab\", \"ac\", \"ad\"]):");
        // Console.WriteLine(string.Join(", ", FirstSwap.Solve(new string[] { "ab", "ac", "ad" })));
    }

    // Helper method to convert Dictionary<string, T> to Dictionary<string, object>
    static Dictionary<string, object> ConvertToObjectMap<T>(Dictionary<string, T> input)
    {
        return input.ToDictionary(kvp => kvp.Key, kvp => (object)kvp.Value);
    }
}
