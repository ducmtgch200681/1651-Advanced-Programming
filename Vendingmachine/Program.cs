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
                Console.WriteLine("\nWelcome to Kevin the vendingmachine! \nPlease choose your drink: \n1. Coke($2) \n2. Water($1) \n3. Tea($1.5) \n4. Exit");
                // Console.WriteLine("\nEnter your choice: ");
                // option = Convert.ToInt32(Console.ReadLine());

                

                switch(GetDrinkChoice())
                {
                    case 1:
                        Console.WriteLine("Coke is $2");
                        Console.WriteLine("How many you want to buy: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill = quantity*2;
                        Console.WriteLine("Total: " + bill);

                        Pay(bill);

                        // Console.WriteLine("Your cash: ");
                        // cash = Convert.ToInt32(Console.ReadLine());
                        // if (cash != 1 && cash !=2 && cash !=5 && cash != 10){
                        //     Console.WriteLine("Invalid currency!");
                        //     break;
                        // }
                        // if (cash > bill)
                        // {
                        //     change = cash - bill;
                        //     Console.WriteLine("Here your change: " + change);
                        //     Console.WriteLine("Thankyou for purchase! <3");
                        //     break;
                        // }
                        // if (cash == bill)
                        // {
                        //     Console.WriteLine("Thankyou for purchase! <3");
                        //     break;
                        // }
                        // if (cash < bill)
                        // {
                        //     for(change = bill - cash; change < bill ; change -= cash){
                        //         if (change <= 0){
                        //             Console.WriteLine("Thankyou for purchase! <3");
                        //             break;
                        //         }

                        //         Console.WriteLine("Your bill: " + bill);
                        //         Console.WriteLine("Infusion amount of money: " + change);
                        //         Console.WriteLine("Deposit money: ");
                        //         cash = Convert.ToInt32(Console.ReadLine());

                        //         if (cash != 1 && cash !=2 && cash !=5 && cash != 10){
                        //             Console.WriteLine("Invalid currency!");
                        //             break;
                        //         }

                        //         if (cash > change)
                        //         {
                        //             change = cash - change;
                        //             Console.WriteLine("Here your change: " + change);
                        //             Console.WriteLine("Thankyou for purchase! <3");
                        //             break;
                        //         }
                        //     }
                        // }
                        break;
                    case 2:
                        Console.WriteLine("Water is $1");
                        Console.WriteLine("How many you want to buy: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill = quantity*1;
                        Console.WriteLine("Total: " + bill);
                        Console.WriteLine("Your cash: ");
                        cash = Convert.ToInt32(Console.ReadLine());
                        if (cash != 1 && cash !=2 && cash !=5 && cash != 10){
                            Console.WriteLine("Invalid currency!");
                            break;
                        }
                        if (cash > bill)
                        {
                            change = cash - bill;
                            Console.WriteLine("Here your change: " + change);
                            Console.WriteLine("Thankyou for purchase! <3");
                            break;
                        }
                        if (cash == bill)
                        {
                            Console.WriteLine("Thankyou for purchase! <3");
                            break;
                        }
                        if (cash < bill)
                        {
                            for(change = bill - cash; change < bill ; change -= cash){
                                if (change <= 0){
                                    Console.WriteLine("Thankyou for purchase! <3");
                                    break;
                                }

                                Console.WriteLine("Your bill: " + bill);
                                Console.WriteLine("Infusion amount of money: " + change);
                                Console.WriteLine("Deposit money: ");
                                cash = Convert.ToInt32(Console.ReadLine());

                                if (cash != 1 && cash !=2 && cash !=5 && cash != 10){
                                    Console.WriteLine("Invalid currency!");
                                    break;
                                }

                                if (cash > change)
                                {
                                    change = cash - change;
                                    Console.WriteLine("Here your change: " + change);
                                    Console.WriteLine("Thankyou for purchase! <3");
                                    break;
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Tea is $1.5");
                        Console.WriteLine("How many you want to buy: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        bill = quantity*1.5;
                        Console.WriteLine("Total: " + bill);
                        Console.WriteLine("Your cash: ");
                        cash = Convert.ToInt32(Console.ReadLine());
                        if (cash != 1 && cash !=2 && cash !=5 && cash != 10){
                            Console.WriteLine("Invalid currency!");
                            break;
                        }
                        if (cash > bill)
                        {
                            change = cash - bill;
                            Console.WriteLine("Here your change: " + change);
                            Console.WriteLine("Thankyou for purchase! <3");
                            break;
                        }
                        if (cash == bill)
                        {
                            Console.WriteLine("Thankyou for purchase! <3");
                            break;
                        }
                        if (cash < bill)
                        {
                            for(change = bill - cash; change < bill ; change -= cash){
                                if (change <= 0){
                                    Console.WriteLine("Thankyou for purchase! <3");
                                    break;
                                }

                                Console.WriteLine("Your bill: " + bill);
                                Console.WriteLine("Infusion amount of money: " + change);
                                Console.WriteLine("Deposit money: ");
                                cash = Convert.ToInt32(Console.ReadLine());

                                if (cash != 1 && cash !=2 && cash !=5 && cash != 10){
                                    Console.WriteLine("Invalid currency!");
                                    break;
                                }

                                if (cash > change)
                                {
                                    change = cash - change;
                                    Console.WriteLine("Here your change: " + change);
                                    Console.WriteLine("Thankyou for purchase! <3");
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            while (GetDrinkChoice() != 4);

            
        }
        // get drink choice
            static int GetDrinkChoice()
            {
                bool invalid = true;
                int option = 0;
                while (invalid)
                {
                    Console.WriteLine("Enter your choice (1-4): ");
                    option = int.Parse(Console.ReadLine());
                    // invalid = choice != 1 && choice != 2 && choice != 3;
                    invalid = option < 1 || option > 4;
                    if (invalid)
                    Console.WriteLine("Invalid choice. Please try again!");
                }
                return option;
            }

            // get number of drinks
            static int GetNumberOfDrinks()
            {
                int quantity;
                Console.WriteLine("How many you want to buy: ");
                quantity = int.Parse(Console.ReadLine());
                return quantity;
            }

            // cash in and check valid currentcy
            // static double CashIn()
            // {
            //     double cash;
            //     Console.WriteLine("Your cash: ");
            //     cash = int.Parse(Console.ReadLine());
            //     if (cash != 1 && cash !=2 && cash !=5 && cash != 10){
            //         Console.WriteLine("Invalid currency!");
            //         break;
            //     }
                
            // }

            // payment
            static void Pay(double bill)
            {
                double cash;
                double change;

                Console.WriteLine("Your cash: ");
                cash = int.Parse(Console.ReadLine());

                do{
                    Console.WriteLine("Invalid currency!");
                    break;
                    
                }while (cash != 1 && cash !=2 && cash !=5 && cash != 10);

                 do
                    {
                        change = cash - bill;
                        Console.WriteLine("Here your change: " + change);
                        Console.WriteLine("Thankyou for purchase! <3");
                        break;
                        
                    }while(cash > bill);
                do 
                    {
                        Console.WriteLine("Thankyou for purchase! <3");
                        break;
                        
                    }while(cash == bill);
                do
                    {
                        for(change = bill - cash; change < bill ; change -= cash){
                            do{
                                // if (change <= 0){
                                    Console.WriteLine("Thankyou for purchase! <3");
                                    break;
                                    
                                // }
                            }while(change <= 0);
                            

                            Console.WriteLine("Your bill: " + bill);
                            Console.WriteLine("Infusion amount of money: " + change);
                            Console.WriteLine("Deposit money: ");
                            cash = Convert.ToInt32(Console.ReadLine());

                            do{
                                Console.WriteLine("Invalid currency!");
                                break;
                                
                            }while(cash != 1 && cash !=2 && cash !=5 && cash != 10);

                            
                            do{
                                change = cash - change;
                                Console.WriteLine("Here your change: " + change);
                                Console.WriteLine("Thankyou for purchase! <3");
                                break;
                                
                            }while(cash > change);
                        }
                    }while (cash < bill);
            }
    }
}