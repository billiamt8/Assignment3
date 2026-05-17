using CsvHelper.Configuration;
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
        public string ProductEAN { get; set; }
        public string ProductColor { get; set; }
        public string ProductSize { get; set; }
        public string ProductAvailability { get; set; }
        public int InternalID { get; set; }

        public Product()
        {

        }
        public Product(int id, string name, string description, string brand, string category, decimal price, string currency, int quantity, string ean, string color, string size, string availability, int internalId)
        {
            ProductID = id;
            ProductName = name;
            ProductDescription = description;
            ProductBrand = brand;
            ProductCategory = category;
            ProductPrice = price;
            ProductCurrency = currency;
            ProductQuantity = quantity;
            ProductEAN = ean;
            ProductColor = color;
            ProductSize = size;
            ProductAvailability = availability;
            InternalID = internalId;
        }
        
        public sealed class ProductMap : ClassMap<Product>
        {
            public ProductMap()
            {
                Map(m => m.ProductID).Name("ProductID");
                Map(m => m.ProductName).Name("ProductName");
                Map(m => m.ProductDescription).Name("ProductDescription"); 
                Map(m => m.ProductBrand).Name("ProductBrand");
                Map(m => m.ProductCategory).Name("ProductCategory");
                Map(m => m.ProductPrice).Name("Price");
                Map(m => m.ProductCurrency).Name("ProductCurrency");
                Map(m => m.ProductQuantity).Name("Quantity");
                Map(m => m.ProductEAN).Name("ProductEAN");
                Map(m => m.ProductColor).Name("ProductColor");
                Map(m => m.ProductSize).Name("Size");
                Map(m => m.ProductAvailability).Name("Availability");
                Map(m => m.InternalID).Name("Internal ID");
            }
        }
    }
}