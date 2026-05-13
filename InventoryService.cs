using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3
{
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            List<Product> products = new List<Product>();
            if (!File.Exists(filePath)) return products;

            var lines = File.ReadAllLines(filePath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 12)
                {
                    try
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string description = parts[2];
                        string brand = parts[3];
                        string category = parts[4];
                        decimal price = decimal.Parse(parts[5]) / 100m;
                        string currency = parts[6];
                        int quantity = int.Parse(parts[7]);
                        int ean = int.Parse(parts[8]);
                        string color = parts[9];

                        products.Add(new Product(id, name, description, brand, category, price, currency, quantity, ean, color));
                    }
                    catch
                    {
                        // Skips rows with formatting errors
                    }
                }
            }
            return products;
        }

        public static void SaveToCSV(string filePath, List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Match header exactly
                writer.WriteLine("ProductID,ProductName,ProductDescription,ProductBrand,ProductCategory,Price,ProductCurrency,Quantity");

                foreach (var p in products)
                {
                    // Converts price back to cents for storage and includes quantity
                    string line = $"{p.ProductID},{p.ProductName},{p.ProductDescription},{p.ProductBrand},{p.ProductCategory},{p.ProductPrice * 100},{p.ProductCurrency},{p.ProductQuantity},{p.ProductEAN}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}