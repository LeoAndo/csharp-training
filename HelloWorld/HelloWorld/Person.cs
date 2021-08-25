using System;

namespace HelloWorld
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name + " Age: " + Age);
        }

        public string Name
        {
            private set; get;
        }
        public int Age
        {
            set; get;
        }
    }
}
