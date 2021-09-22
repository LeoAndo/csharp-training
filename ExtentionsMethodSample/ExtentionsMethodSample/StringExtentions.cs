using System;
namespace ExtentionsMethodSample
{
    public static class StringExtentions
    {
        public static void Greet(this string name)
        {
            Console.WriteLine($"Hello, {name}");// Hello, Tanaka
        }
    }
}
