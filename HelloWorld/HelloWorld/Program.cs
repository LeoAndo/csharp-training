using System;

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
            TestTupleSample();
            TestObjectReferenceEquals();
            TestMultiConstoractors();
            int remainder = 0;
            int divRet = TestDivide(4, 2, out remainder);
            Console.WriteLine($"remainder: {remainder}, divRet: {divRet}");
            int divRet2 = TestDivide(7, 2, out remainder);
            Console.WriteLine($"remainder: {remainder}, divRet2: {divRet2}");
        }

        private static void TestStringInterpolation()
        {
            string name = "Tanaka";
            int age = 30;
            string message = $"Name: {name}, Age: {age}";
            Console.WriteLine(message);
        }
        private static void TestTupleSample()
        {
            // タプルの作成と使用
            (int x, int y) point = (10, 20);
            Console.WriteLine($"X: {point.x} Y: {point.y}");

            // 初期化子でのタプルメンバの名前付け
            var point2 = (x: 30, y: 40);
            Console.WriteLine($"X: {point2.x} Y: {point2.y}");

            // 変数からタプルメンバ名を推測する
            int x = 50, y = 60;
            var point3 = (x, y);
            Console.WriteLine($"X: {point3.x} Y: {point3.y}");

            // デフォルトのタプルメンバ名
            var point4 = (70, 80);
            Console.WriteLine($"Item1: {point4.Item1} Item2: {point4.Item2}");

            // Tuple型の値の分解
            (x, y) = point4;
            Console.WriteLine($"X: {x} Y: {y}");
        }
        private static void TestObjectReferenceEquals()
        {
            Console.WriteLine("START : TestObjectReferenceEquals");
            Person tanaka = new Person("Tanaka", 20);
            Person tanaka2 = tanaka;
            Person tanaka3 = new Person("Tanaka", 20);

            Console.WriteLine($"(tanaka, tanaka2): {object.ReferenceEquals(tanaka, tanaka2)}");
            Console.WriteLine($"(tanaka, tanaka3): {object.ReferenceEquals(tanaka, tanaka3)}");
            Console.WriteLine($"(null, tanaka3): {object.ReferenceEquals(null, tanaka3)}");

            Console.WriteLine($"(tanaka, tanaka2): {(tanaka == tanaka2)}");
            Console.WriteLine($"(tanaka, tanaka3): {(tanaka == tanaka3)}");
            Console.WriteLine($"(null, tanaka3): {(null == tanaka3)}");
            Console.WriteLine("END : TestObjectReferenceEquals");
        }

        private static void TestMultiConstoractors()
        {
            Console.WriteLine("START - TestMultiConstoractors");
            Person defPerson = new Person();
            defPerson.ShowInfo();
            Person tanaka = new Person("Tanaka");
            tanaka.ShowInfo();
            Person yoshida = new Person("Yoshida", 50);
            yoshida.ShowInfo();
            Console.WriteLine("END - TestMultiConstoractors");
        }
        private static int TestDivide(int x, int y, out int remainder)
        {
            remainder = x % y;
            return x / y;
        }
    }
}
