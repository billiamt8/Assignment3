using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;
using static Assignment3.Product;

namespace Assignment3
{
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            List<Product> products = new List<Product>();
            using (var reader = new StreamReader("./products-100.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    csv.Context.RegisterClassMap<ProductMap>();
                    Product product = csv.GetRecord<Product>();
                    products.Add(product);
                }
            }
            return products;
        }
        

        public static void SaveToCSV(string filePath, List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Match header exactly
                writer.WriteLine("ProductID,ProductName,ProductDescription,ProductBrand,ProductCategory,Price,ProductCurrency,Quantity,ProductEAN,ProductColor,ProductSize,ProductAvailability");

                foreach (var p in products)
                {
                    // Converts price back to cents for storage and includes quantity
                    string line = $"{p.ProductID},{p.ProductName},{p.ProductDescription},{p.ProductBrand},{p.ProductCategory},{p.ProductPrice * 100},{p.ProductCurrency},{p.ProductQuantity},{p.ProductEAN},{p.ProductColor},{p.ProductSize},{p.ProductAvailability}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}