using System;

namespace LocalVariableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var greetText = "Hello, C#"; // 静的型付け
            Console.WriteLine(greetText);
            dynamic greetText2 = "Hello, C#"; // 動的型付け
            Console.WriteLine(greetText2);
            greetText2 = 100;
            Console.WriteLine(greetText2);
        }
    }
}
