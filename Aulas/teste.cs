using System;

class Sample
{
    public static void Main()
    {

        DateTime date1 = DateTime.Now;
        DateTime date2 = DateTime.UtcNow;
        DateTime date3 = DateTime.Today;

        Console.WriteLine(date2);
    }
}