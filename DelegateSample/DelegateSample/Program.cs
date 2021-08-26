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
            Console.WriteLine("{0} x 2 = {1}", number, number * 2);
        }
        static void TenTimes(int number)
        {
            Console.WriteLine("{0} x 10 = {1}", number, number * 10);
        }

        static void Main(string[] args)
        {
            Action action = new Action(ShowNumber);
            // 処理の追加も可能
            action += new Action(TwoTimes);
            action += new Action(TenTimes);
            action(3);
        }
    }
}
