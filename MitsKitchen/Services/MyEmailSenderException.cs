using System;

namespace MitsKitchen.Services
{
    public class MyEmailSenderException : ApplicationException
    {
        private const string StandardErrorMessage = "Something went Wrong";

        public MyEmailSenderException() : base(StandardErrorMessage)
        {

        }
        public MyEmailSenderException(string message):base(message)
        {

        }
        public MyEmailSenderException(string message, Exception innerexception) : base(message, innerexception)
        {

        }
    }
}
