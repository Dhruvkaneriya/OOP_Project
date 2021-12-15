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

                Console.Write("Enter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Add new product information");
                    Console.WriteLine("");
                    Pd.add_details();
                }

                else if (option == 2)
                {

                    Console.Clear();
                    Console.WriteLine("List all the products infromation");
                    Console.WriteLine("");
                    Pd.view_details();
                }
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
