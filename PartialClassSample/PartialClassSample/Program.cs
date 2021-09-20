using System;

namespace PartialClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialTest test = new PartialTest();
            test.sayHello();
            test.sayGoodbye();
        }
    }
}
