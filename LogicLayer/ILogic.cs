using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace LogicLayer
{
    public interface ILogic
    {
        int GetProductCount();
        string GetProductName(int index);
        int GetProductId(int index);
        string GetProductDescription(int index);
        int GetProductPrice(int index);
        int GetProductSellerId(int index);
        int GetCustomerCount();
        int GetCustomerId(int index);
        string GetCustomerFirstName(int index);
        string GetCustomerLastName(int index);
        string GetCustomerCountry(int index);
        string GetCustomerCity(int index);
        string GetCustomerStreet(int index);
        int GetCustomerHouseNumber(int index);
        int GetCustomerAppartmentNumber(int index);
        string GetCustomerPostalCode(int index);
        string GetCustomerPhoneNumber(int index);
        string GetCustomerEmail(int index);
        int GetRepairsCount();
        int GetRepairId(int index);
        string GetRepairItemName(int index);
        string GetRepairDescription(int index);
        int GetRepairPrice(int index);
        bool GetRepairIsDone(int index);
        int GetRepairCustomerId(int index);
        int GetSellerCount();
        int GetSellerId(int index);
        string GetSellerName(int index);
        string GetSellerCountry(int index);
        string GetSellerCity(int index);
        string GetSellerStreet(int index);
        int GetSellerHouseNumber(int index);
        int GetSellerAppartmentNumber(int index);
        string GetSellerPostalCode(int index);
        string GetSellerPhoneNumber(int index);
        string GetSellerEmail(int index);
        int GetSaleCount();
        int GetSaleId(int index);
        int GetSaleCustomerId(int index);
        bool CreateCustomer(string firstName, string lastName, string country, string city, string street, int houseNumber, int appartmentNumber, string postCode, string phoneNumber, string email);
        bool CreateSeller(string name, string country, string city, string street, int houseNumber, int appartmentNumber, string postCode, string phoneNumber, string email);
        bool CreateProduct(string name, string description, int price, int sellerId);
        bool CreateRepair(string itemName, string description, int price, int customerId);
        bool CreateSale(int customerId, List<int> productIds);
        bool RepairDone(int Id);
        int GetSalesPrice(int index);
    }
}
