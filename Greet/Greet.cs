using System;

namespace Greet
{
    public class Greeting   : IGreeting
    {
        public string GetGreetingMessage()
        {
            string message = String.Empty;
            if (DateTime.Now.Hour < 12)
            {
                message = "Good Morning";
            }
            else if (DateTime.Now.Hour < 17)
            {
                message = "Good Afternoon";
            }
            else
            {
                message = "Good Evening";
            }
            return message;
        }
    }

    public interface IGreeting
    {

        String GetGreetingMessage();
    }
}
