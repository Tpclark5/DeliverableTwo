using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int checksum = 0;
            string input = "";
            string message = "";
            Console.Write("Enter your message: ");
            input = Console.ReadLine();
            string inputUpper = input.ToUpper();

            {
                foreach (char item in inputUpper)
                {
                    string userCode = (item - 64).ToString();
                    message += userCode + "-";
                    checksum += item;

                };

                Console.WriteLine($"Your encoded message is {message}");
                Console.WriteLine($"The checksum is {checksum}");
            }
        }
    }
}
