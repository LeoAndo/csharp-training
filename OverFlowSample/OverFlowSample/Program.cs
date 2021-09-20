using System;

namespace OverFlowSample
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = Byte.MaxValue; // 255
            b += 1;
            Console.WriteLine(b); // 0
        }
    }
}
