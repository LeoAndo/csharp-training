using System;

namespace PropertySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person yamada = new Person("yamada", 20);
            yamada.Name = "Yamada Jr";
            yamada.Greeting();
        }
    }
}
