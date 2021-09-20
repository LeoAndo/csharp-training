﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, world!");
            Console.WriteLine("My Name is {0} {1}. ", "Taro", "Yamada");
            const string name = "Yamada";
            // name = "Tanaka"; // 値の再代入を禁止する

            Person yamadaObj = new Person(name, 20);
            yamadaObj.ShowInfo();
            yamadaObj.Age = 21;
            yamadaObj.ShowInfo();

            TestStringInterpolation();
        }

        private static void TestStringInterpolation()
        {
            string name = "Tanaka";
            int age = 30;
            string message = $"Name: {name}, Age: {age}";
            Console.WriteLine(message);
        }
    }
}
