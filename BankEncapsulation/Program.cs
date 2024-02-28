using System.Data;

namespace BankEncapsulation
{
    public class Program
    {
        public static void Wait4KeyPress()
        {
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            bool keepGoing = true;
            var gregBA = new BankAccount();

            do
            {
                Console.Clear();
                Console.WriteLine("\n  ____       _     _         _                         ____");
                Console.WriteLine(" / ___|_   _(_) __| | ___   | |    ___   __ _ _ __    / ___|___");
                Console.WriteLine("| |  _| | | | |/ _` |/ _ \\  | |   / _ \\ / _` | '_ \\  | |   / _ \\");
                Console.WriteLine("| |_| | |_| | | (_| | (_) | | |__| (_) | (_| | | | | | |__| (_) |");
                Console.WriteLine(" \\____|\\__,_|_|\\__,_|\\___/  |_____\\___/ \\__,_|_| |_|  \\____\\___(_)");
                Console.WriteLine("\n\nPlease make your selection:");
                Console.WriteLine("1. Deposit money into your Account");
                Console.WriteLine("2. Withdraw money from your Account");
                Console.WriteLine("3. Check the balace of your Account");
                Console.WriteLine("0. Exit");
                if (int.TryParse(Console.ReadLine(), out int uSelect))
                {                
                   switch (uSelect)
                   {
                    case 1:
                        Console.WriteLine("Enter the amount of money you wish to desposit:");
                        double.TryParse(Console.ReadLine(), out double funds);
                        gregBA.Deposit(funds);
                        Wait4KeyPress();
                        break;
                    case 2:
                        Console.WriteLine("You can deposit any time you like, but you can never withdraw!");
                        Wait4KeyPress();
                        break;
                    case 3:
                        Console.WriteLine($"Your balance is ${gregBA.CheckBalance()}");
                        Wait4KeyPress();
                        break;
                    case 0:
                        Console.WriteLine("\n\nThanks for stopping by, come back soon!");
                        keepGoing = false;
                        break;
                    default:
                        break;
                   };
                } else
                {
                    Console.WriteLine($"\n\nOops! Please select a valid option.");
                    Wait4KeyPress();
                };                                
            } while (keepGoing);
        }
    }
}
