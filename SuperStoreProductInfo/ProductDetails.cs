using System;
using System.Collections.Generic;

namespace SuperStoreProductInfo
{
    public class ProductDetails : ProductOptions
    {
        informations info = new informations();

        List<ProductOptions> product_info = new List<ProductOptions>();

        public void add_details()
        {
            Console.Write("Product ID: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product Category: ");
            var product_category = Console.ReadLine();
            Console.Write("Product name: ");
            var product_name = Console.ReadLine();
            Console.Write("Brand: ");
            var brand = Console.ReadLine();
            Console.Write("Price: ");
            var price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Barcode: ");
            var barcode = Convert.ToDouble(Console.ReadLine());

            product_info.Add(new ProductOptions(id,product_category,product_name,brand,price,barcode));
            
            info.press_any_key();
        }

        public void view_details()
        {
            if (product_info.Count > 0)
            {
                foreach (var show_product_info in product_info)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"Product ID: {show_product_info.ID}");
                    Console.WriteLine($"Product Category: {show_product_info.Product_Category}");
                    Console.WriteLine($"Product name: {show_product_info.Product_Name}");
                    Console.WriteLine($"Brand: {show_product_info.Brand}");
                    Console.WriteLine($"Price: {show_product_info.Price}");
                    Console.WriteLine($"Barcode: {show_product_info.Barcode}");
                    Console.WriteLine("--------------------------------------------");
                }
            }

            else
            {
                info.no_details();
            }

            info.press_any_key();

            Console.WriteLine("");
        }
    }
}
