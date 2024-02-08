using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    abstract class Delivery
    {
        public int id;
        protected internal string Address;

        public Delivery(int id, string address)
        {
            this.id = id;
            Address = address;
        }
       
    }

    class HomeDelivery : Delivery
    {
        public string CouriersName;        
        public string DeliveryProvider;
        public HomeDelivery(int id, string address, string CouriersName, string DeliveryProvider) : base(id, address) {
            this.CouriersName = CouriersName;
            this.DeliveryProvider = DeliveryProvider;
        }         
    }

    internal class PickPointDelivery : Delivery
    {
        public string PickPointName;

        public PickPointDelivery(int id, string address, string PickPointName) : base(id, address)
        {
            this.PickPointName = PickPointName;
        }        
    }

    class ShopDelivery : Delivery
    {
        public string ShopName;
        
        public ShopDelivery(int id, string address, string ShopName) : base(id, address)
        {
            this.ShopName = ShopName;
        }
        
    }

    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int id;

        public string Product;
        public double Quantity;
        public double Prise;
        public decimal SumPrice;
        public string Customer;
        
        public void DisplayAddress()
        {
            //Console.WriteLine(Delivery.);
        }

        // ... Другие поля
    }

    abstract class General 
    {
        //public int id;
        public string Name;
        public General(string Name)
        {
            //this.id = id;
            this.Name = Name;
        }
    }

    class Product : General
    {
        public decimal PurchasePrice;
        public decimal SallingPrice;
        public string MeasureUnit;
        public string Description;
        public string Provider;
        public Product(string Name, decimal PurchasePrice, decimal SallingPrice, string MeasureUnit, string Description, string Provider) : base(Name)
        {
            this.PurchasePrice = PurchasePrice;
            this.SallingPrice = SallingPrice;
            this.MeasureUnit = MeasureUnit;
            this.Description = Description;
            this.Provider = Provider;
    }
    }

    class Provider : General
    {        
        private string Phone;
        private string Contact;
        public Provider(string Name, string Phone, string Contact) : base(Name)
        {
            this.Phone = Phone;
            this.Contact = Contact;
        }
    }

    class Customer : General
    {
        public string Address;
        public string Phone; 
        public Customer(string Name, string Address, string Phone) : base(Name)
        {
            this.Address = Address;
            this.Phone = Phone;
        }
    }

    class GeneralList 
    {
        public static int id;
        //public List<Object> list;
        public GeneralList(int ID /*List<object> list*/)
        {
            id = ID;
            //this.list = new List<Object>();
        }
        
    }

    class CustomerList : GeneralList
    {
        public List<Customer> customerList;
        public CustomerList(List<Customer> customerList) : base(id)
        {
            this.customerList = new List<Customer>();
        }
    }
/*
    class ProductList : GeneralList
    {
        //public Product MyProduct = new Product(1);
    }

    class ProviderList : GeneralList
    {
        //public Provider MyProvider = new Provider();
    }*/

    class Program
    {
       
        
        static void Main(string[] args)
        {
            //Product prod1 = new Product();
            //prod1.id = 1;
            //Console.WriteLine(prod1.id);
            //HomeDelivery home = new HomeDelivery(12, "Кудыкина гора", "Иванов", "ООО Кривое колесо");
            Customer cust1 = new Customer("Ромашка", "Далеко", "3223322");
            Customer cust2 = new Customer("Цветочек", "За горой", "459876");
            //Console.WriteLine(cust2);

            //Console.WriteLine(home.Address);
            
            
            Console.ReadKey();
        }

    }
}
