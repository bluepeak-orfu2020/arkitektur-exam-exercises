using System;
using System.Text.RegularExpressions;

namespace Application
{
    class Program
    {
        private static readonly int MEMBERSHIP_SILVER_LEVEL = 2;
        private static readonly int MEMBERSHIP_GOLD_LEVEL = 4;
        private static readonly int MEMBERSHIP_DIAMOND_LEVEL = 10;

        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Enter desired username");
            string input = Console.ReadLine();

            if (input == "" || new Regex(@"^[0-9]").IsMatch(input))
            {
                Console.WriteLine("Invalid username");
                return;
            }
            user.Username = input;

            Console.WriteLine("Enter password");
            input = Console.ReadLine();

            Console.WriteLine("Enter password again");
            string pw = Console.ReadLine();

            if (input.Length < 5 || input.Length > 20 || input != pw)
            {
                Console.WriteLine("Invalid password");
                return;
            }
            user.Password = input;

            Console.WriteLine("Enter age");
            input = Console.ReadLine();

            if (!new Regex(@"^[0-9]+$").IsMatch(input))
            {
                Console.WriteLine("Invalid age");
                return;
            }
            user.Age = int.Parse(input);

            Console.WriteLine("Enter membership length (in year(s))");
            input = Console.ReadLine();

            if (!new Regex(@"^[0-9]+$").IsMatch(input))
            {
                Console.WriteLine("Invalid membership length");
                return;
            }
            user.MembershipLength = int.Parse(input);

            if ((user.Age < 18 || user.Age >= 65) && user.MembershipLength >= 8 || user.MembershipLength >= 10)
            {
                user.DiscountLevel = MEMBERSHIP_DIAMOND_LEVEL;
            }
            else if ((user.Age < 18 || user.Age >= 65) && user.MembershipLength >= 5 || user.MembershipLength >= 6)
            {
                user.DiscountLevel = MEMBERSHIP_GOLD_LEVEL;
            }
            else
            {
                user.DiscountLevel = MEMBERSHIP_SILVER_LEVEL;
            }

            Console.WriteLine($"User created {user}");
        }
    }
}
