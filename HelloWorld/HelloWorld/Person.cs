using System;

namespace HelloWorld
{
    public class Person
    {
        public Person() : this("DefaultName") { }
        public Person(string name) : this(name, 100) { }
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
