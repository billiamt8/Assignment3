using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCurrency { get; set; }
        public int ProductQuantity { get; set; }

        public Product(int id, string name, string description, string brand, string category, decimal price, string currency, int quantity)
        {
            ProductID = id;
            ProductName = name;
            ProductDescription = description;
            ProductBrand = brand;
            ProductCategory = category;
            ProductPrice = price;
            ProductCurrency = currency;
            ProductQuantity = quantity;
        }

    }
}