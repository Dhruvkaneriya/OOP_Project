using System;

namespace SuperStoreProductInfo
{
    public class informations : AbstractClass
    {
        // introduction method call from the abstract class
        public override void introduction()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Super Store Products Info Database ");
            Console.WriteLine("");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please choose any option you want");
            Console.WriteLine("");
            Console.ResetColor();

        }

        // menu list method call from the abstract class
        public override void menu_list()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("option 1 : Add new product information");
            Console.WriteLine("Option 2 : List all the products infromation");
            Console.WriteLine("Option 3 : Exit");
            Console.WriteLine("");
        }

        // press any key method call from the abstract class
        public override void press_any_key()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Press any key continue....");
            Console.ReadLine();
            Console.ResetColor();
        }

        // invalid option call from the abstract class
        public override void invalid_option()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorry! your option is not valid, please enter option between 1 and 3 ");
            Console.ResetColor();
        }

        // no details call from the abstract class
        public override void no_details()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorry you didn't enter product details");
            Console.ResetColor();
        }
    }
}
