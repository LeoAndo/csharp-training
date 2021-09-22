using System;

namespace DefaultMethodParamSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo();
            Foo(name: "yamada");
            Foo(name: "yamada", age: 20);
        }

        private static void Foo(string name = "tanaka", int age = 100)
        {
            Console.WriteLine($"name: {name}, age: {age}");
        }
    }
}
