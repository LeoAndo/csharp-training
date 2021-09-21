using System;

namespace GenericSmaple
{
    internal class ValueHolder<T>
    {
        public ValueHolder()
        {
        }
        public T Value { get; internal set; }

        internal void Foo1<U>(U v)
        {
            Console.WriteLine(v);
        }
    }
}