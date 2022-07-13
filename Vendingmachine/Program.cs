using System;

namespace Vendingmachine
{
    class Program
    {
        static void Main (string[] args)
        {
            int option;
            int quantity;
            double bill;
            double cash;
            double change;

            do
            {
                Console.WriteLine("\nWelcome to Kevin the vendingmachine! \nPlease choose your drink: \n1. Cok($2) \n2. Water($1) \n3. Tea($1.5) \n4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Coke is $2");
                        Console.WriteLine("How many you want to buy: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill = quantity*2;
                        Console.WriteLine("Total: " + bill);
                        Console.WriteLine("Your cash: ");
                        cash = Convert.ToInt32(Console.ReadLine());
                        if (cash > bill)
                        {
                            change = cash - bill;
                            Console.WriteLine("Here your change: " + change);
                            Console.WriteLine("Thankyou for purchase! <3");
                        }
                        if (cash == bill)
                        {
                            Console.WriteLine("Thankyou for purchase! <3");
                        }
                        break;
                    case 2:
                        Console.WriteLine("2");
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                }
            }
            while (!option.Equals(4));
            
            
        }
    }
}