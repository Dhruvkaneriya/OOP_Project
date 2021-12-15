using System;

namespace SuperStoreProductInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDetails Pd = new ProductDetails();
            informations info = new informations();

            while (true)
            {
                info.introduction();

                info.menu_list();

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();

                // if user enter "1" so call this option
                if (option == 1)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Add new product information");
                    Console.WriteLine("");
                    Console.ResetColor();

                    // add details method call from the product details class
                    Pd.add_details();
                }

                // if user enter "2" so call this option
                else if (option == 2)
                {

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("List all the products infromation");
                    Console.WriteLine("");
                    Console.ResetColor();

                    // view details method call from the product details class
                    Pd.view_details();
                }

                // if user enter "3" so call this option
                else if (option == 3)
                {
                    break;
                }

                else
                {
                    info.invalid_option();
                    info.press_any_key();
                }
            }
        }
    }
}
