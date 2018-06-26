using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }
        }
        
        static void Main(string[] args)
        {
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            int inputProducts = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputProducts; i++)
            {
                string[] prod = Console.ReadLine().Split('-');
                products[prod[0]] = decimal.Parse(prod[1]);
            }
            List<Customer> customers = new List<Customer>();
            string[] inputCustomer = Console.ReadLine().Split(new char[] { '-', ',' }).ToArray();
            while (inputCustomer[0] != "end of clients")
            {
                string name = inputCustomer[0];
                string product = inputCustomer[1];
                int quantity = int.Parse(inputCustomer[2]);
                if (products.ContainsKey(product))
                {
                    bool existingCustomer = false;//opredelq dali sushtestvuva takyv cutomer
                    Customer customer = new Customer(); 
                    customer.Name = name;
                    customer.ShopList = new Dictionary<string, int>();
                    customer.ShopList.Add(product, quantity);
                    customer.Bill = products[product] * quantity;
                    foreach (var c in customers)
                    {
                        if (c.Name == customer.Name)
                        {
                            existingCustomer = true;//syshtestvuva
                            if (c.ShopList.ContainsKey(product))
                                c.ShopList[product] += quantity;
                            else
                                c.ShopList.Add(product, quantity);
                            c.Bill += products[product] * quantity;
                        } 
                    }
                    if (!existingCustomer)//ne systhtestvuva
                    {
                        customers.Add(customer);
                    }
                }
                inputCustomer = Console.ReadLine().Split('-',',');
            }
            decimal totalSum = 0;
            foreach (var item in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(item.Name);
                foreach (var product in item.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", product.Key, product.Value);
                }
                Console.WriteLine("Bill: {0:f2}", item.Bill);
                totalSum += item.Bill;
            }
            Console.WriteLine("Total bill: {0:f2}", totalSum);
        }
    }
}
