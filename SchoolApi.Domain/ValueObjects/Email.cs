using System;
using ValueOf;

namespace SchoolApi.Domain.ValueObjects
{
    public class Email : ValueOf<string, Email>
    {
        protected override void Validate()
        {
            var trimmedEmail = Value.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                throw new InvalidEmailException(Value);
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(Value);
                if(addr.Address != trimmedEmail)
                    throw new InvalidEmailException(Value);
            }
            catch
            {
                throw new InvalidEmailException(Value);
            }
        }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string email)
            : base($"The string provided is not in valid email format. Value provided: {email}")
        {
            
        }
    }
}