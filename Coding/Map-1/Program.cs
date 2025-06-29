using Map_1;

public class Program
{
    static void PrintMap(Dictionary<string, string> map)
    {
        Console.Write("{");
        bool first = true;
        foreach (var kvp in map)
        {
            if (!first)
            {
                Console.Write(", ");
            }
            Console.Write($"{kvp.Key}: '{kvp.Value}'");
            first = false;
        }
        Console.WriteLine("}");
    }
    static void Main(string[] args)
    {
        // MAP-1 TEST CASES
        Console.WriteLine("mapBully({a: 'candy', b: 'dirt'}):");
        PrintMap(MapBully.Solve(new Dictionary<string, string> { { "a", "candy" }, { "b", "dirt" } }));

        Console.WriteLine("mapShare({a: 'aaa', b: 'bbb', c: 'ccc'}):");
        PrintMap(MapShare.Solve(new Dictionary<string, string> { { "a", "aaa" }, { "b", "bbb" }, { "c", "ccc" } }));

        Console.WriteLine("mapAB({a: 'Hi', b: 'There'}):");
        PrintMap(MapAB.Solve(new Dictionary<string, string> { { "a", "Hi" }, { "b", "There" } }));

        //Console.WriteLine("topping1({ice cream: 'peanuts'}):");
        //PrintMap(Topping1.Solve(new Dictionary<string, string> { { "ice cream", "peanuts" } }));

        //Console.WriteLine("topping2({ice cream: 'cherry'}):");
        //PrintMap(Topping2.Solve(new Dictionary<string, string> { { "ice cream", "cherry" } }));

        //Console.WriteLine("topping3({potato: 'ketchup'}):");
        //PrintMap(Topping3.Solve(new Dictionary<string, string> { { "potato", "ketchup" } }));

        //Console.WriteLine("mapAB2({a: 'aaa', b: 'aaa'}):");
        //PrintMap(MapAB2.Solve(new Dictionary<string, string> { { "a", "aaa" }, { "b", "aaa" } }));

        Console.WriteLine("mapAB3({a: 'aaa'}):");
        PrintMap(MapAB3.Solve(new Dictionary<string, string> { { "a", "aaa" } }));

        Console.WriteLine("mapAB4({a: 'Hi', b: 'There'}):");
        PrintMap(MapAB4.Solve(new Dictionary<string, string> { { "a", "Hi" }, { "b", "There" } }));
    }
   
}