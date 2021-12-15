using System;

namespace SuperStoreProductInfo
{
    public class informations : AbstractClass
    {
        public override void introduction()
        {
            Console.Clear();
            Console.WriteLine("Website Info Database ");
            Console.WriteLine("");

            Console.WriteLine("Please choose any option you want");
            Console.WriteLine("");

        }

        public override void menu_list()
        {
            Console.WriteLine("option 1 : Add new product information");
            Console.WriteLine("Option 2 : List all the products infromation");
            Console.WriteLine("Option 3 : Exit");
            Console.WriteLine("");
        }

        public override void press_any_key()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key continue....");
            Console.ReadLine();
        }

        public override void invalid_option()
        {
            Console.WriteLine("Sorry! your option is not valid, please enter option between 1 and 3 ");
        }
        
        public override void no_details()
        {
            Console.WriteLine("Sorry you didn't enter website details");
        }
    }
}
