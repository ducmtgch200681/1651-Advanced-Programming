using System;

namespace Vacation
{
    class Program
    {
        const int DANANG_ADULT = 100;
        const int DANANG_CHILDREN = 50;
        const int HALONG_ADULT = 60;
        const int HALONG_CHILDREN = 30;
        const int PHUYEN_ADULT = 120;
        const int PHUYEN_CHILDREN = 80;
        const int PROMO1 = 50;
        const int PROMO2 = 25;

        static void Main(String[] args)
        {
            while (true)
            {
            printMenu();
            string location = selectLocation();
            if (location == "") break;
            int AdultTickets = getNumberOfTicket("Adult");
            int ChildrenTickets = getNumberOfTicket("Children");
            int Promo1 = getNumberOfPromo1();
            int Promo2 = getNumberOfPromo2();
            int bill = getBill(location, AdultTickets, ChildrenTickets, Promo1, Promo2);
            Pay(bill);
            }
        }

        private static void printMenu()
        {
            Console.WriteLine("\nWelcome to Duke company vacation register app!");
            Console.WriteLine("Please choose the vacation you want");
            Console.WriteLine("1. Da Nang ($100 adult, $50 children)");
            Console.WriteLine("2. Ha Long ($60 adult, $30 children)");
            Console.WriteLine("3. Phu Yen ($120 adult, $80 children)");
            Console.WriteLine("4. Exit the app!\n");
        }

        private static string selectLocation()
        {
            bool invalid = true;
            int option;
            string location = "Nigger";

            while (invalid)
            {
                Console.WriteLine("Choose the location you want");
                option = int.Parse(Console.ReadLine());
                invalid = option < 1 || option > 4;
                if (invalid)
                    Console.WriteLine("Invalid choice. Please choose again!");

                switch (option)
                {
                    case 1:
                        location = "Da Nang";
                        break;
                    case 2:
                        location = "Ha Long";
                        break;
                    case 3:
                        location = "Phu Yen";
                        break;
                    case 4:
                        location = "";
                        break;
                    default:
                        break;
                }
            }
            return location;
        }

        private static int getNumberOfTicket(string ticketType)
        {
            bool invalid = true;
            int quantity = 0;

            while (invalid)
            {
                Console.Write("Enter the number of " + ticketType + " tickets: ");
                quantity = int.Parse(Console.ReadLine());
                invalid = quantity < 1;
                if (invalid)
                    Console.WriteLine("Invalid number of tickets. Please try again!");
            }
            return quantity;
        }

        private static int getNumberOfPromo1()
        {
            bool invalid = true;
            int quantity = 0;

            while (invalid)
            {
                Console.Write("Press 1 if you have your husband or wife go along with, \npress 0 if don't have any: ");
                quantity = int.Parse(Console.ReadLine());
                invalid = quantity < 0 || quantity > 1;
                if (invalid)
                    Console.WriteLine("Invalid choice. Please try again!");
            }
            return quantity;
        }

        private static int getNumberOfPromo2()
        {
            bool invalid = true;
            int quantity = 0;

            while (invalid)
            {
                Console.Write("How many of your children are coming with you?, \npress 0 if don't have any: ");
                quantity = int.Parse(Console.ReadLine());
                invalid = quantity < 0;
                if (invalid)
                    Console.WriteLine("Invalid choice. Please try again!");
            }

            if (quantity > 4)
                    quantity = 4;

            return quantity;
        }

        private static int getBill(string location, int AdultTickets, int ChildrenTickets, int Promo1, int Promo2)
        {
            int bill = 0;
            int Atickets = 0;
            int Ctickets = 0;
            int info1 = Promo1 * PROMO1;
            int info2 = Promo2 * PROMO2;

            if (location == "Da Nang"){
                bill = (AdultTickets * DANANG_ADULT + ChildrenTickets * DANANG_CHILDREN - info1 - info2);
                Atickets = AdultTickets * DANANG_ADULT;
                Ctickets = ChildrenTickets * DANANG_CHILDREN;
            }
                
            if (location == "Ha Long"){
                bill = (AdultTickets * HALONG_ADULT + ChildrenTickets * HALONG_CHILDREN - info1 - info2);
                Atickets = AdultTickets * HALONG_ADULT;
                Ctickets = ChildrenTickets * HALONG_CHILDREN;
            }
                
            if (location == "Phu Yen"){
                bill = (AdultTickets * PHUYEN_ADULT + ChildrenTickets * PHUYEN_CHILDREN - info1 - info2);
                Atickets = AdultTickets * PHUYEN_ADULT;
                Ctickets = ChildrenTickets * PHUYEN_CHILDREN;
            }
            Console.WriteLine("\nYour Bill: ");
            Console.WriteLine("--------------------");
            Console.WriteLine("Location: " + location);
            Console.WriteLine("Adult tickets: $" + Atickets);
            Console.WriteLine("Children tickets: $" + Ctickets);
            Console.WriteLine("--------------------");
            Console.WriteLine("Allowance: ");
            Console.WriteLine("Husband or Wife discount (max 1): $" + info1);
            Console.WriteLine("Intestine childs discount (max 4): $" + info2);
            Console.WriteLine("--------------------");
            Console.WriteLine("Total: $" + bill);

            return bill;
        }

        private static void Pay(int bill)
        {
            Console.Write("Your Payment: ");

            bool run = true;
            while (run)
            {
                int money = int.Parse(Console.ReadLine());
                int change = money - bill;

                if (change > 0){
                    Console.WriteLine("Here your change: " + change);
                    Console.WriteLine("Have a nice vacation! <3");
                    run = false;
                }           

                if (change == 0){
                    Console.WriteLine("Have a nice vacation! <3");
                    run = false;
                }

                if (change < 0){
                    bill = -change;
                    Console.WriteLine("Infusion amount of money: " + bill);
                    Console.Write("Please deposit more: ");
                }
            }
        }
    }
}