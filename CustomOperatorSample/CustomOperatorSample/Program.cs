using System;

namespace CustomOperatorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter(10);
            Counter counter2 = new Counter(20);
            Counter counter3 = counter1 + counter2;
            Console.WriteLine(counter3.Count);

            int count1 = (int)counter3 + 10;
            Console.WriteLine(count1);

            Counter counter4 = 50;
            Console.WriteLine(counter4.Count);
        }
    }
}
