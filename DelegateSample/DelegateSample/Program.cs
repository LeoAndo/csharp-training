using System;

namespace DelegateSample
{
    class Program
    {
        // delegateの宣言
        delegate void Action(int number);

        static void ShowNumber(int number)
        {
            Console.WriteLine("number={0}", number);
        }
        static void TwoTimes(int number)
        {
            Console.WriteLine("{0} x 2 = ", number);
        }
        static void TenTimes(int number)
        {
            Console.WriteLine("{0} x 10 = ", number);
        }

        static void Main(string[] args)
        {
            Action action = new Action(ShowNumber);
            action(3);
        }
    }
}
