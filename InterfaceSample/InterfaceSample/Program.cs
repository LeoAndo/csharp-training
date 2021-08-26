using System;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone phone = new CellPhone();
            phone.Call("09012345678");
            phone.SendEmail("foo@gmail.com");
        }
    }
}
