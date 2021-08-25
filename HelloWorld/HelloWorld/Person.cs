namespace HelloWorld
{
    public class Person
    {
        private string name;
        public Person(string _name)
        {
            name = _name;
        }
        public string Name
        {
            // valueに代入された値が格納されている
            set => name = value;
            get => name;
        }
    }
}
