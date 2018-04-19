using System;
using Xunit;
using Greet;
namespace GreetTest
{
    public class GreetingTest
    {
        [Fact]
        public void PassingTest()
        {

            string morning = "Good Morning";
            string evening = "Good Evening";
            string afternoon = "Good Afternoon";
            Greeting greeting = new Greeting();
            string message = greeting.GetGreetingMessage();
            if(DateTime.Now.Hour < 12)
            {
                Assert.Equal(morning, message);
            }else if(DateTime.Now.Hour < 17){
                Assert.Equal(afternoon, message);
            }
            else
            {
                Assert.Equal(evening, message);
            }
        }
    }
}
