using System;
namespace InterfaceSample
{
    public class CellPhone : IPhone, IEmail
    {
        public CellPhone()
        {
        }

        public void Call(string phoneNumber)
        {
            Console.WriteLine("{0} に電話します", phoneNumber);
        }

        public void SendEmail(string email)
        {
            Console.WriteLine("{0} にメール送信します", email);
        }
    }
}
