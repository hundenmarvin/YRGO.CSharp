using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            Three();
        }

        static void One()
        {
            Console.WriteLine("Hello world!");
        }

        static void Two()
        {
            string username;
            string password;

            var success = false;
            var failures = 0;

            while (!success && failures < 3)
            {
                Console.WriteLine("LOGIN");

                Console.Write(" USER     : ");
                username = Console.ReadLine();

                Console.Write(" PASSWORD : ");
                password = Console.ReadLine();

                if (username == "kebab" && password == "svarv")
                {
                    Console.WriteLine("OK");
                    success = true;
                }
                else
                {
                    failures++;
                    Console.WriteLine(" *** ERROR");
                    Console.WriteLine("Login failed. You have {0} attempts left.", 3 - failures);
                }
            }

            if (success)
                Console.WriteLine("Well done, kebab for everyone!");
            else
                Console.WriteLine("No kebab for you!");
        }

        static void Three()
        {
            string category = null;
            bool? discount = null;

            var price = 0;

            Console.WriteLine(" *** Welcome to the Awesome Sparkle Unicorn Megaticket System 2k15 v1.0 *** ");

            while (price == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Category? \"A\", \"B\" or \"C\"");
                Console.Write("> ");
                category = Console.ReadLine().ToUpper();
                switch (category)
                {
                    case "A":
                        price = 500;
                        break;
                    case "B":
                        price = 400;
                        break;
                    case "C":
                        price = 340;
                        break;
                    default:
                        Console.WriteLine("No such category. Try again.");
                        break;
                }
            }


            while (!discount.HasValue)
            {
                Console.WriteLine();
                Console.WriteLine("Are you a student or a senior? Answer \"yes\" or \"no\"");
                Console.Write("> ");
                var discountAnswer = Console.ReadLine().ToUpper();

                switch (discountAnswer)
                {
                    case "YES":
                        discount = true;
                        break;
                    case "NO":
                        discount = false;
                        break;
                    default:
                        Console.WriteLine("Wrong selection. Try again.");
                        break;
                }

            }

            if (discount.Value)
                price -= 100;

            Console.WriteLine();
            Console.WriteLine("You've bought a ticket in category {0}. Please pay: {1}:-", category, price);
        }
    }
}
