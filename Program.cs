using System;

namespace DCIT318_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== DCIT 318 Assignment 2 ===");
                Console.WriteLine("1. Inheritance and Method Overriding");
                Console.WriteLine("2. Abstract Classes and Methods");
                Console.WriteLine("3. Interfaces");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InheritanceDemo.Run();
                        break;
                    case "2":
                        AbstractClassDemo.Run();
                        break;
                    case "3":
                        InterfaceDemo.Run();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1–4.");
                        break;
                }
            }
        }
    }
}
