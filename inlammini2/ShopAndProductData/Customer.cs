using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlammini2.ShopAndProductData
{
    public class Customer
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public static List<Product> Cart = new List<Product>();



        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
        }


        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer("Knatte", "123"),
            new Customer("Fnatte", "321"),
            new Customer ("Tjatte", "213")
        };
        public override string ToString()
        {
            string cartText = "";
            double total = 0;

            if (Cart.Count == 0)
            {
                cartText = "[Empty]";
            }
            else
            {
                foreach (var p in Cart)
                {
                    cartText += $"{p.Name} ({p.Price} kr)\n";
                    total += p.Price;
                }
            }

            return $"Username: {Username}\nPassword: {Password}\nCart:\n{cartText}Total: {total} kr";
        }







    }
}
