using System;
using System.Collections.Generic;

namespace SuperStoreProductInfo
{
    // child class 
    public class ProductDetails : ProductOptions
    {
        informations info = new informations();

        // List call from product options class
        List<ProductOptions> product_info = new List<ProductOptions>();

        // this method is use for add product details from user
        public void add_details()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Product ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product Category: ");
            var product_category = Convert.ToString(Console.ReadLine());
            Console.Write("Product name: ");
            var product_name = Convert.ToString(Console.ReadLine());
            Console.Write("Brand: ");
            var brand = Convert.ToString(Console.ReadLine());
            Console.Write("Price $: ");
            var price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Barcode: ");
            var barcode = Convert.ToDouble(Console.ReadLine());

            product_info.Add(new ProductOptions(id,product_category,product_name,brand,price,barcode));
            Console.ResetColor();

            info.press_any_key();
        }

        // this method show user input product details
        public void view_details()
        {
            if (product_info.Count > 0)
            {
                foreach (var show_product_info in product_info)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine($"Product ID: {show_product_info.ID}");
                    Console.WriteLine($"Product Category: {show_product_info.Product_Category}");
                    Console.WriteLine($"Product name: {show_product_info.Product_Name}");
                    Console.WriteLine($"Brand: {show_product_info.Brand}");
                    Console.WriteLine($"Price $: {show_product_info.Price}");
                    Console.WriteLine($"Barcode: {show_product_info.Barcode}");
                    Console.WriteLine("--------------------------------------------");
                    Console.ResetColor();
                }
            }

            else
            {
                // no details method call from the informations class
                info.no_details();
            }

            // press any key method call from the informations class
            info.press_any_key();

            Console.WriteLine("");
        }
    }
}
