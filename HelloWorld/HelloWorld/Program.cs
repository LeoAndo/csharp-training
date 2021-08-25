using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Name is {0} {1}. ", "Taro", "Yamada");
            const string name = "Yamada";
            // name = "Tanaka"; // 値の再代入を禁止する

            Person yamadaObj = new Person("default name.");
            yamadaObj.Name = name;
            Console.WriteLine("person Name: " + yamadaObj.Name);
        }
    }
}
