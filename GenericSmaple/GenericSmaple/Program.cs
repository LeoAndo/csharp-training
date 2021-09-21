using System;

namespace GenericSmaple
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSimpleGeneric();
        }

        private static void TestSimpleGeneric()
        {
            var valueHolderInt = new ValueHolder<int>();
            valueHolderInt.Value = 10;
            Console.WriteLine($"value : {valueHolderInt.Value}");

            var valueHolderStr = new ValueHolder<string>();
            valueHolderStr.Value = "Hello, Generic!";
            Console.WriteLine($"value : {valueHolderStr.Value}");
        }
    }
}
