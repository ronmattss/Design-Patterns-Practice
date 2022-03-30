using System;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Dependency_Inversion
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending email...");
            Console.WriteLine(message);
        }
    }
}