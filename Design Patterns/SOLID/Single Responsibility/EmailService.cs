// Single Responsibility Principle Example
// Logger class is responsible for logging messages.
// The only thing this class do is log text to the console.


using System;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Single_Responsibility
{
       public class EmailService
       { 
              public void SendEmail(string emailAddress,string subject, string message) => Console.WriteLine( emailAddress +"\n "+subject+"\n "+ message);
       }
}