using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperStoreProductInfo
{
    // parent class 
    public class ProductOptions
    {
            public int ID { get; set; }
            public string Product_Category { get; set; }
            public string Product_Name { get; set; }
            public string Brand { get; set; }
            public double Price { get; set; }
            public double Barcode { get; set; }

            // public constructor
            public ProductOptions(int id ,string product_category, string product_name, string brand, double price, double barcode)
            {
                ID = id;
                Product_Category = product_category;
                Product_Name = product_name;
                Brand = brand;
                Price = price;
                Barcode = barcode;
            }

        public ProductOptions()
        { }
    }
}
