using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;
using System.IO;

namespace LogicLayer
{
    public class InformationSystem: ILogic
    {
        //all private as there is no need for anything else but this class to access them
        private List<Sale> Sales;
        private List<Customer> Customers;
        private List<Repair> Repairs;
        private List<Seller> Sellers;
        private List<Product> Products;
        private SerializeDeserialize serializeDeserialize;

        public InformationSystem()
        {
            serializeDeserialize = new SerializeDeserialize();

            //populate the Lists with data from json files
            Sales = serializeDeserialize.DeserializeSales();
            Customers = serializeDeserialize.DeserializeCustomers();
            Repairs = serializeDeserialize.DeserializeRepairs();
            Sellers = serializeDeserialize.DeserializeSellers();
            Products = serializeDeserialize.DeserializeProducts();
        }

        //as GUI has no access to ModelLayer we get the count of products in the list and then ask this class for each products name, id, etc.
        //we use the index of the object in the List to get the information we need
        public int GetProductCount()
        {
            return Products.Count;
        }

        public string GetProductName(int index)
        {
            return Products[index].Name;
        }

        public int GetProductId(int index)
        {
            return Products[index].Id;
        }

        public string GetProductDescription(int index)
        {
            return Products[index].Description;
        }

        public int GetProductPrice(int index)
        {
            return Products[index].Price;
        }

        public int GetProductSellerId(int index)
        {
            return Products[index].Seller.Id;
        }

        //Customer getters
        public int GetCustomerCount()
        {
            return Customers.Count;
        }

        public int GetCustomerId(int index)
        {
            return Customers[index].Id;
        }

        public string GetCustomerFirstName(int index)
        {
            return Customers[index].FirstName;
        }

        public string GetCustomerLastName(int index)
        {
            return Customers[index].LastName;
        }

        public string GetCustomerCountry(int index)
        {
            return Customers[index].Country;
        }

        public string GetCustomerCity(int index)
        {
            return Customers[index].City;
        }

        public string GetCustomerStreet(int index)
        {
            return Customers[index].Street;
        }

        public int GetCustomerHouseNumber(int index)
        {
            return Customers[index].HouseNumber;
        }

        public int GetCustomerAppartmentNumber(int index)
        {
            return Customers[index].AppartmentNumber;
        }

        public string GetCustomerPostalCode(int index)
        {
            return Customers[index].PostalCode;
        }

        public string GetCustomerPhoneNumber(int index)
        {
            return Customers[index].PhoneNumber;
        }

        public string GetCustomerEmail(int index)
        {
            return Customers[index].Email;
        }

        //Repair getters
        public int GetRepairsCount()
        {
            return Repairs.Count;
        }

        public int GetRepairId(int index)
        {
            return Repairs[index].Id;
        }

        public string GetRepairItemName(int index)
        {
            return Repairs[index].ItemName;
        }

        public string GetRepairDescription(int index)
        {
            return Repairs[index].Description;
        }

        public int GetRepairPrice(int index)
        {
            return Repairs[index].Price;
        }

        public bool GetRepairIsDone(int index)
        {
            return Repairs[index].IsDone;
        }

        public int GetRepairCustomerId(int index)
        {
            return Repairs[index].Customer.Id;
        }

        //Seller getters
        public int GetSellerCount()
        {
            return Sellers.Count;
        }

        public int GetSellerId(int index)
        {
            return Sellers[index].Id;
        }

        public string GetSellerName(int index)
        {
            return Sellers[index].Name;
        }

        public string GetSellerCountry(int index)
        {
            return Sellers[index].Country;
        }

        public string GetSellerCity(int index)
        {
            return Sellers[index].City;
        }

        public string GetSellerStreet(int index)
        {
            return Sellers[index].Street;
        }

        public int GetSellerHouseNumber(int index)
        {
            return Sellers[index].HouseNumber;
        }

        public int GetSellerAppartmentNumber(int index)
        {
            return Sellers[index].AppartmentNumber;
        }

        public string GetSellerPostalCode(int index)
        {
            return Sellers[index].PostalCode;
        }

        public string GetSellerPhoneNumber(int index)
        {
            return Sellers[index].PhoneNumber;
        }

        public string GetSellerEmail(int index)
        {
            return Sellers[index].Email;
        }

        //Sale getters
        public int GetSaleCount()
        {
            return Sales.Count;
        }

        public int GetSaleId(int index)
        {
            return Sales[index].Id;
        }

        public int GetSaleCustomerId(int index)
        {
            return Sales[index].Customer.Id;
        }

        //Create methods for each class in ModelLayer
        public bool CreateCustomer(string firstName, string lastName, string country, string city, string street, int houseNumber, int appartmentNumber, string postCode, string phoneNumber, string email)
        {
            int id = Customers.Count + 1;

            Customers.Add(new Customer()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Country = country,
                City = city,
                Street = street,
                HouseNumber = houseNumber,
                AppartmentNumber = appartmentNumber,
                PostalCode = postCode,
                PhoneNumber = phoneNumber,
                Email = email
            });

            return serializeDeserialize.Serialize(Customers);
        }

        public bool CreateSeller(string name, string country, string city, string street, int houseNumber, int appartmentNumber, string postCode, string phoneNumber, string email)
        {
            int id = Sellers.Count + 1;

            Sellers.Add(new Seller()
            {
                Id = id,
                Name = name,
                Country = country,
                City = city,
                Street = street,
                HouseNumber = houseNumber,
                AppartmentNumber = appartmentNumber,
                PostalCode = postCode,
                PhoneNumber = phoneNumber,
                Email = email
            });

            return serializeDeserialize.Serialize(Sellers);
        }

        public bool CreateProduct(string name, string description, int price, int sellerId)
        {
            int id = Products.Count + 1;

            Seller seller = Sellers.Find(x => x.Id == sellerId);

            Products.Add(new Product()
            {
                Id = id,
                Name = name,
                Description = description,
                Price = price,
                Seller = seller
            });

            return serializeDeserialize.Serialize(Products);
        }

        public bool CreateRepair(string itemName, string description, int price, int customerId)
        {
            int id = Repairs.Count + 1;

            Customer customer = Customers.Find(x => x.Id == customerId);

            Repairs.Add(new Repair()
            {
                Id = id,
                ItemName = itemName,
                Description = description,
                Price = price,
                IsDone = false,
                Customer = customer
            });

            return serializeDeserialize.Serialize(Repairs);
        }

        public bool CreateSale(int customerId, List<int> productIds)
        {
            int id = Sales.Count + 1;

            Customer customer = Customers.Find(x => x.Id == customerId);

            List<Product> products = new List<Product>();

            foreach (var item in productIds)
            {
                products.Add(Products.Find(x => x.Id == item));
            }

            Sales.Add(new Sale()
            {
                Id = id,
                Customer = customer,
                Products = products
            });

            return serializeDeserialize.Serialize(Sales);
        }

        //method to set Repair bool value IsDone to true, thus saying that the service been completed
        public bool RepairDone(int Id)
        {
            Repairs.Find(x => x.Id == Id).IsDone = true;

            return serializeDeserialize.Serialize(Repairs);
        }

        //getter to get the total price of products in Sale's Product List
        public int GetSalesPrice(int index)
        {
            int price = 0;

            foreach (var item in Sales[index].Products)
            {
                price = price + item.Price;
            }

            return price;
        }
    }
}