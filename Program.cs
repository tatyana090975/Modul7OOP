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

        //public int id;
        public ProductList productName;
        public double Quantity;
        public decimal Prise;
        public decimal SumPrice;
        public CustomerList customerName;

        public Order(TDelivery Delivery, ProductList productName, double Quantity, decimal Prise, decimal SumPrice, CustomerList customerName)
        {
            this.Delivery = Delivery;
            this.productName = productName;
            this.Quantity = Quantity;
            this.Prise = Prise;
            this.SumPrice = SumPrice;
            this.customerName = customerName;
        }
        
        public void DisplayAddress()
        {
            //Console.WriteLine(Delivery.);
        }



        
    }

    abstract class General 
    {        
        public string Name;
        public General(string Name)
        {            
            this.Name = Name;
        }
    }

    class Product : General
    {
        public decimal PurchasePrice;
        public decimal SallingPrice;
        public string MeasureUnit;
        public string Description;
        public ProviderList Provider;
        public Product(string Name, decimal PurchasePrice, decimal SallingPrice, string MeasureUnit, string Description, List<ProviderList> Provider) : base(Name)
        {
            this.PurchasePrice = PurchasePrice;
            this.SallingPrice = SallingPrice;
            this.MeasureUnit = MeasureUnit;
            this.Description = Description;
            this.Provider = new ProviderList();
    }
    }

    class Provider : General
    {        
        public string Phone;
        public string Contact;
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
        
        public GeneralList(int ID)
        {
            id = ID;            
        }
    }

    class CustomerList : GeneralList
    {
        public List<Customer> customerList;
        public CustomerList() : base(id)
        {            
            customerList = new List<Customer>();
        }
        
        public void AddToCustomer(Customer customer)
        {            
            customerList.Add(customer);           
        }

        public void PrintCustomerList(CustomerList cl)
        {            
            foreach (var c in cl.customerList)
            {
                id = customerList.IndexOf(c) + 1;
                Console.WriteLine($"{id} {c.Name} {c.Address} {c.Phone}");
            }
        }
        public int GetID(Customer customer)
        {
            {
                id = customerList.IndexOf(customer) + 1;
                return id;
            }
        }
    }

    class ProductList : GeneralList
    {
        public List<Product> productList;
        public ProductList() : base(id)
        {
            productList = new List<Product>();
        }

        public void AddToProduct(Product product)
        {
            productList.Add(product);
        }

        public void PrintProductList(ProductList pl)
        {
            foreach (var c in pl.productList)
            {
                id = productList.IndexOf(c) + 1;
                Console.WriteLine($"{id} {c.Name} {c.PurchasePrice} {c.MeasureUnit} {c.SallingPrice} {c.Description} {c.Provider}");
            } 
        }

        public int GetID(Product product)
        {
            {
                id = productList.IndexOf(product) + 1;
                return id;
            }
        }
    }

    class ProviderList : GeneralList
    {
        public List<Provider> providerList;
        public ProviderList() : base(id)
        {
            providerList = new List<Provider>();
        }

        public void AddToProvider(Provider provider)
        {
            providerList.Add(provider);
        }

        public void PrintProviderList(ProviderList pr)
        {
            foreach (var c in pr.providerList)
            {
                id = providerList.IndexOf(c) + 1;
                Console.WriteLine($"{id} {c.Name} {c.Phone} {c.Contact}");
            }
        }
        public int GetID(Provider provider)
        {
            { 
                id = providerList.IndexOf(provider) + 1;
                return id;
            }
        }
    }

    class Program
    {
       
        
        static void Main(string[] args)
        {
            
            //prod1.id = 1;
            //Console.WriteLine(prod1.id);
            //HomeDelivery home = new HomeDelivery(12, "Кудыкина гора", "Иванов", "ООО Кривое колесо");
            CustomerList cl1 = new CustomerList();
            Customer cust1 = new Customer("Ромашка", "Далеко", "3223322");            
            Customer cust2 = new Customer("Цветочек", "За горой", "459876");

            cl1.AddToCustomer(cust1);
            cl1.AddToCustomer(cust2);
            //cl1.PrintCustomerList(cl1);
            Console.WriteLine(cl1.GetID(cust1));
            

            //Console.WriteLine(home.Address);
            
            
            Console.ReadKey();
        }

    }
}
