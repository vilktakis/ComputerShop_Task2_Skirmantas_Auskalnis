using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ModelLayer;

namespace DataLayer
{
    //In this class we have 8 methods 4 for Serialization to Json file and 4 for Deserialization from Json file to List collections
    //Serialize methods have try/catch and bool return value to take care of exeptions that might happen
    //Deserialize methods are used once when the program is launched and try/catch for exeption catching is done is done by GUI
    public class SerializeDeserialize
    {
        public bool Serialize(List<Sale> sales)
        {
            try
            {
                string fileName = "Sales.json";
                string jsonString = JsonSerializer.Serialize(sales);
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Serialize(List<Customer> customers)
        {
            try
            {
                string fileName = "Customers.json";
                string jsonString = JsonSerializer.Serialize(customers);
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Serialize(List<Seller> sellers)
        {
            try
            {
                string fileName = "Sellers.json";
                string jsonString = JsonSerializer.Serialize(sellers);
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Serialize(List<Product> products)
        {
            try
            {
                string fileName = "Products.json";
                string jsonString = JsonSerializer.Serialize(products);
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Serialize(List<Repair> repairs)
        {
            try
            {
                string fileName = "Repairs.json";
                string jsonString = JsonSerializer.Serialize(repairs);
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Sale> DeserializeSales()
        {
            string fileName = "Sales.json";
            string jsonString = File.ReadAllText(fileName);
            List<Sale> sales = JsonSerializer.Deserialize<List<Sale>>(jsonString);
            return sales;
        }

        public List<Customer> DeserializeCustomers()
        {
            string fileName = "Customers.json";
            string jsonString = File.ReadAllText(fileName);
            List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(jsonString);
            return customers;
        }

        public List<Seller> DeserializeSellers()
        {
            string fileName = "Sellers.json";
            string jsonString = File.ReadAllText(fileName);
            List<Seller> sellers = JsonSerializer.Deserialize<List<Seller>>(jsonString);
            return sellers;
        }

        public List<Product> DeserializeProducts()
        {
            string fileName = "Products.json";
            string jsonString = File.ReadAllText(fileName);
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString);
            return products;
        }

        public List<Repair> DeserializeRepairs()
        {
            string fileName = "Repairs.json";
            string jsonString = File.ReadAllText(fileName);
            List<Repair> repairs = JsonSerializer.Deserialize<List<Repair>>(jsonString);
            return repairs;
        }
    }
}
