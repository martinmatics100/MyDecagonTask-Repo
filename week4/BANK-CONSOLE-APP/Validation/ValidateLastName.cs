using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_CONSOLE_APP.Validation
{
    public class ValidateLastName
    {
        public string ValidLNameCollector()
        {
            while (true)
            {
                Console.Write("Enter Your LastName (Kindly begin name with uppercase): ");
                string LastName = Console.ReadLine()!;
                if (string.IsNullOrEmpty(LastName))
                {
                    Console.WriteLine("Invalid input. Please enter a valid first name.");
                    Console.Beep();
                    continue;
                }

                if (!Char.IsUpper(LastName[0]))
                {
                    Console.WriteLine("Your name did not start with upper case, try again");
                    Console.Beep(); 
                    continue;
                }

                if (Char.IsDigit(LastName[0]))
                {
                    Console.WriteLine("Your name must not start with a number");
                    continue;
                }

                return LastName;
            }
        }
    }
}
