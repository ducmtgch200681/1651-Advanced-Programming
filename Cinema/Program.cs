using System;

namespace Cinema
{
    class Program
    {
        static void Main (string[] args)
        {
            while (true)
            {
                PrintMenu();
                string movie = SelectMovie();
                if (movie == "") break;
                int Aticket = GetAdultTicket();
                int Cticket = GetChildrenTicket();
                int Total = GetBill(movie, Aticket, Cticket);
                Pay(Total);
            }
            
        }

        // Menu
        static void PrintMenu()
        {   
            Console.WriteLine("\nWelcome to Duke cinema!");
            Console.WriteLine("Now Playing: ");
            Console.WriteLine("1. Thor 4");
            Console.WriteLine("2. Minion");
            Console.WriteLine("3. Land of Death");
            Console.WriteLine("4. Exit!");
        }

        // selected movie
        private static string SelectMovie()
        {
            bool invalid = true;
            int option;
            string movie = "...";

            while (invalid)
            {
                Console.WriteLine("Choose the Movie you want");
                option = int.Parse(Console.ReadLine());
                invalid = option < 1 || option > 4;
                if (invalid)
                    Console.WriteLine("Invalid choice. Please choose again!");

                
                switch(option)
                {
                    case 1: 
                        movie = "Thor 4";
                        break;
                    case 2:
                        movie = "Minion";
                        break;
                    case 3:
                        movie = "Land of Death";
                        break;
                    case 4:
                        movie = "";
                        break;
                    default:
                        break;
                }
            }
            
            return movie;
        }

        // Adult ticket
        private static int GetAdultTicket()
        {
            int Aticket;

            Console.Write("Number of adult ticket ($2): ");
            Aticket = int.Parse(Console.ReadLine());

            return Aticket * 2;
        }

        // Children ticket
        private static int GetChildrenTicket()
        {
            int Cticket;

            Console.Write("Number of children ticket ($1): ");
            Cticket = int.Parse(Console.ReadLine());

            return Cticket;
        }

        // Bill
        private static int GetBill(string movie, int Aticket, int Cticket)
        {
            int Total;
            Total = Aticket + Cticket;

            Console.WriteLine("Your bill: ");
            Console.WriteLine("Movie: " + movie);
            Console.WriteLine("Adult tickets:    $" + Aticket);
            Console.WriteLine("Children tickets: $" + Cticket);
            Console.WriteLine("Total             $" + Total);
            return Total;
        }

        // Payment
        static void Pay(int Total)
        {
            Console.Write("Your Payment: ");


            bool run = true;
            while (run)
            {
                int money = int.Parse(Console.ReadLine());
                int change = money - Total;

                if (change > 0){
                    Console.WriteLine("Here your change: " + change);
                    Console.WriteLine("Have a nice movie! <3");
                    run = false;
                }           

                if (change == 0){
                    Console.WriteLine("Have a nice movie! <3");
                    run = false;
                }

                if (change < 0){
                    Total = -change;
                    Console.WriteLine("Infusion amount of money: " + Total);
                    Console.Write("Please deposit more: ");
                }
            }
        }
    }
}