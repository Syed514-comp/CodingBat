public static class SleepIn
{
    public static bool CanSleepIn(bool weekday, bool vacation)
    {
        return !weekday || vacation;
    }

    static void Main(string[] args)
    {

       
            // Test case 1: It's a weekday and not vacation, so should NOT sleep in
            bool result1 = CanSleepIn(true, false);
            Console.WriteLine($"Weekday: true, Vacation: false -> Can sleep in? {result1}"); // Expected: False

            // Test case 2: It's a weekday but vacation, so CAN sleep in
            bool result2 = CanSleepIn(true, true);
            Console.WriteLine($"Weekday: true, Vacation: true -> Can sleep in? {result2}"); // Expected: True

            // Test case 3: Not a weekday and not vacation, so CAN sleep in
            bool result3 = CanSleepIn(false, false);
            Console.WriteLine($"Weekday: false, Vacation: false -> Can sleep in? {result3}"); // Expected: True

            // Test case 4: Not a weekday and vacation, so CAN sleep in
            bool result4 = CanSleepIn(false, true);
            Console.WriteLine($"Weekday: false, Vacation: true -> Can sleep in? {result4}"); // Expected: True
      

    }
}