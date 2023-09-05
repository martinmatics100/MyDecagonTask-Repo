using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_CONSOLE_APP.Test
{
    [TestFixture]
    public class LoginTest
    {
        [Test]
        public void LoginWithValidCredentials_ShouldSucceed()
        {
            // Arrange
            Login login = new Login();
            string testEmail = "martin@gmail.com";
            string testPassword = "85465955#";

            
            Registration.customers.Add(new Customer("John", "Doe", testEmail, testPassword, "12345", "Savings", 1000));

            
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Set up StringReader to provide input when prompted
            StringReader stringReader = new StringReader(testEmail + Environment.NewLine + testPassword + Environment.NewLine + "0");
            Console.SetIn(stringReader);

            // Act
            login.LoginFunction();

            // Assert
            string consoleOutput = stringWriter.ToString();
            Assert.IsFalse(consoleOutput.Contains("Logged in successfully"));

           
        }


        [Test]
        public void LoginWithInvalidCredentials_ShouldFail()
        {
            // Arrange
            Login login = new Login();
            string testEmail = "martin@gmail.com";
            string testPassword = "testpassword";

            // Add a test customer with different email or password
            Registration.customers.Add(new Customer("John", "Doe", "wrongEmail", "wrongpassword", "12345", "Savings", 1000));

           
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            
            StringReader stringReader = new StringReader(testEmail + Environment.NewLine + testPassword + Environment.NewLine + "0");
            Console.SetIn(stringReader);

            // Act
            login.LoginFunction();

            // Assert
            string consoleOutput = stringWriter.ToString();
            Assert.IsFalse(consoleOutput.Contains("Invalid email or password"));

        }
    }
}
