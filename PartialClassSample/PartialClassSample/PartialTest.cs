using System;

namespace PartialClassSample
{
    internal partial class PartialTest
    {
        internal void sayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
    internal partial class PartialTest
    {
        internal void sayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}