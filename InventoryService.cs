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
            using (var reader = new StreamReader(filePath))
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
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Match header exactly
                csv.WriteRecords(products);
            }
        }
    }
}