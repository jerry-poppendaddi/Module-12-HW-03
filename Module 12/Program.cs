using System;
using Module_12.User;

namespace Module_12
{
    class Program
    {
        static void Main(string[] args) 
        {
            User.User user = new User.User();
            Console.WriteLine("Enter your login:");
            user.Login = Console.ReadLine();
            Console.WriteLine("Enter your name:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Do you have premium subscription? (Y/N)");
            var premiumResponse = Console.ReadLine();
            if (premiumResponse == "Y")
            {
                Console.WriteLine("Greetings," + user.Name);
            }
            else if (premiumResponse == "N")
            {
                ShowAds();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect input");
                Console.Read();
            }
        }
        static void ShowAds()
        {
            Console.WriteLine("Visit our free gaming website: free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Purchase our music subscription!");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Purchase our premium subscription if you don't want to see these ads.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
     
    } 
}
