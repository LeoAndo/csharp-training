using System;

namespace PropertySample
{
    internal class Person
    {
        private string _name;
        private int _age;
        public Person(string _name, int _age)
        {
            this._name = _name;
            this._age = _age;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            internal set
            {
                _name = value;
            }
        }

        private int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }


        internal void Greeting()
        {
            Console.WriteLine($"Hello, {Name}, Age: {Age}");
        }
    }
}