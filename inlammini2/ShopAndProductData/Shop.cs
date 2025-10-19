using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlammini2.ShopAndProductData
{
    static class Shop
    {

        private static Customer loggedInCustomer;

        private static List<Product> Inventory = new List<Product>()
        {
            new Electronics("Samsung S24", 11000, "A Phone with 8 GB RAM, triple camera internal memory 128 GB", "Samsung", "Android 14", "Phone", 24),
            new Electronics("Iphone 15", 13999 , "A phone with 10 GB RAM, Tripple camera internal memory 300 gb", "Apple", "Ios 26", "Phone",24),
            new Electronics(" Dell 7490", 1500, "A laptop with 16 GB RAM, 14'' Screen. 256 gb M.2 SSD", "Dell", "Windows 10/11", "Laptop", 12),
            new Electronics("Macbook air", 20000,"A laptop with 8 GB RAM, 14'' screen , 1 TB M.2 SSD","Apple", "MacOS 20", "Laptop",12),
            new Clothes("Alvina",299, "A nice and stylish sundress with cressed pockets", "HM", "M"),
            new Clothes("Suit", 5999, "Slim cut Suit with a double cut vent", "Hugo BOSSE", "52"),
            new Clothes("Kalvin", 290, "Unisex pants with cuffed capris and a double pocket", "Kappahl", "L"),
            new Clothes("Sandrina", 424, "one piece pyjamas", "Scarlet Johanson", "XXXXXXXL"),
            new Food ("Apple", 20, "Fruit", 2025 ),
            new Food("Spaggeti", 140, "Pasta", 2027),
            new Food("Cola zero", 16, "Drink", 2030),
            new Food("Bonaqua", 18, "Drink", 2025)
        };




        public static void Run()
        {

            bool running = true;


            while (running)
            {
                Console.WriteLine("======Login Terminal======");
                Console.WriteLine("[1] Add user");
                Console.WriteLine("[2] Login");
                Console.WriteLine("[3] Quit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Add username:");
                        string username = Console.ReadLine()!;

                        Console.WriteLine("Add password:");
                        string password = Console.ReadLine()!;

                        Customer newCustomer = new Customer(username, password);

                        Customer.Customers.Add(newCustomer);

                        loggedInCustomer = newCustomer;


                        Console.WriteLine("Customer added succossfully");
                        break;

                    case "2":
                        Console.WriteLine("Input your username:");
                        string user = Console.ReadLine()!;

                        Console.WriteLine("Input your password:");
                        string pass = Console.ReadLine()!;

                        bool userfound = false;

                        foreach (var c in Customer.Customers)
                        {
                            if (c.Username == user)
                            {
                                userfound = true;
                                loggedInCustomer = c;



                                while (c.Password != pass)
                                {
                                    Console.WriteLine("Wrong password bro, please try again");

                                    pass = Console.ReadLine()!;
                                }

                                break;
                            }
                        }


                        if (!userfound)
                        {
                            Console.WriteLine("No user found , please create an account");
                        }
                        else
                        {
                            Console.WriteLine("Login succeded would you like to shop now? Y/N");

                            if (Console.ReadLine()!.ToLower() == "y")

                            {

                                bool isshopping = true;

                                while (isshopping)
                                {
                                    Console.WriteLine($"Welcome to the shop  please select what you wish to do:");

                                    Console.WriteLine("======Shop Terminal======");
                                    Console.WriteLine(loggedInCustomer);
                                    Console.WriteLine();
                                    Console.WriteLine("[1] Shop");
                                    Console.WriteLine("[2] Logout");

                                    string choice = Console.ReadLine()!;

                                    switch (choice)
                                    {
                                        case "1":

                                            foreach (var p in Inventory)
                                            {
                                                Console.WriteLine($"Product: {p.Name} Price: {p.Price} Description: {p.Description}");


                                            }
                                            Console.WriteLine("Please input the number of the product you wish to add to your cart (1-12)");

                                            string shopchoice = Console.ReadLine()!;

                                            if (shopchoice == "1")

                                            {
                                                Customer.Cart.Add(Inventory[0]);
                                            }

                                            else if (shopchoice == "2")
                                            {
                                                Customer.Cart.Add(Inventory[1]);
                                            }
                                            else if (shopchoice == "3")
                                            {
                                                Customer.Cart.Add(Inventory[2]);
                                            }
                                            else if (shopchoice == "4")
                                            {
                                                Customer.Cart.Add(Inventory[3]);
                                            }
                                            else if (shopchoice == "5")
                                            {
                                                Customer.Cart.Add(Inventory[4]);
                                            }
                                            else if (shopchoice == "6")
                                            {
                                                Customer.Cart.Add(Inventory[5]);
                                            }
                                            else if (shopchoice == "7")
                                            {
                                                Customer.Cart.Add(Inventory[6]);
                                            }
                                            else if (shopchoice == "8")
                                            {
                                                Customer.Cart.Add(Inventory[7]);
                                            }
                                            else if (shopchoice == "9")
                                            {
                                                Customer.Cart.Add(Inventory[8]);
                                            }
                                            else if (shopchoice == "10")
                                            {
                                                Customer.Cart.Add(Inventory[9]);
                                            }
                                            else if (shopchoice == "11")
                                            {
                                                Customer.Cart.Add(Inventory[10]);
                                            }
                                            else if (shopchoice == "12")
                                            {
                                                Customer.Cart.Add(Inventory[11]);
                                            }

                                            else
                                            {
                                                Console.WriteLine("Invalid choice , please input a number from 1 to 12");

                                            }

                                            Console.WriteLine("Would you like to keep shopping J/N (Exiting will take you to checkout)");

                                            string input = Console.ReadLine()!;

                                            if (input.ToLower() == "n")
                                            {

                                                isshopping = false;


                                                Console.WriteLine("Checking out...");
                                                double checkouttotal = 0;
                                                foreach (var item in Customer.Cart)
                                                {
                                                    checkouttotal += item.Price;
                                                }
                                                Console.WriteLine($"Your total is: {checkouttotal}");
                                                Customer.Cart.Clear();
                                                Console.WriteLine("Thank you for your purchase!");



                                            }
                                            else if (input.ToLower() == "y")
                                            {
                                                isshopping = true;
                                            }

                                            else
                                            {
                                                Console.WriteLine("Invalid choice, returning to shop menu");

                                            }



                                            break;

                                        case "2":


                                            running = false;

                                            break;

                                        default:

                                            Console.WriteLine("Invalalid choice, try again");

                                            break;



                                    }
                                }

                            }

                            else
                            {
                                Console.WriteLine("Logout succeded");


                            }




                        }
                        break;








                }
            }
        }
    }
}







