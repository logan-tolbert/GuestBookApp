using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleUI
{
    internal static class ConsoleMessages
    {
        public static void AppIntro()
        {
            Console.WriteLine("   Charp GuestServices");
            Console.WriteLine("  ---------------------");
        }

        public static string GetUserName()
        {

            string message = "Enter your name: ";
            string name = string.Empty;
            bool getInput = true;

            do
            {
                Console.Write(message);
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    getInput = false;
                }
            } while (getInput);

            return name;
        }

        public static void GreetUser(string userName)
        {
            string greeting = $"Hello, {userName}\n";
            Console.Write(greeting);
            Console.WriteLine("Press enter to start guest services.");
            Console.ReadKey();

            Console.Clear();
        }

        public static string GetGuestName()
        {
            bool getInput = true;
            string welcomeGuest = "Welcome to the party!\n";
            string getName = "Please enter your last name: ";
            string lastName = "";
            Console.Write(welcomeGuest);

            do
            {
                Console.Write(getName);
                lastName = Console.ReadLine();

                if (string.IsNullOrEmpty(getName))
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    getInput = false;
                }
            } while (getInput);
            Console.Clear();
            return lastName;
        }

        public static int GetNumberInParty()
        {
            string GetNumber = "Please enter the number of guest/guests in your party: ";
            int NumberInParty;
            bool isNumber = false;

            do
            {
                Console.Write(GetNumber);
                isNumber = int.TryParse(Console.ReadLine(), out NumberInParty);

                if (isNumber)
                {
                    isNumber = true;
                }
                Console.WriteLine("Input invalid.");
            } while (isNumber == false);
            Console.WriteLine("Enjoy the party!!!!");
            return NumberInParty;


        }
        public static bool CheckForMoreGuests()
        {
            string message = "Add more guests?\n Enter [y/n]: ";

            Console.Write(message);
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void OutputGuestList(Dictionary<string, int> database)
        {
            foreach (KeyValuePair<string, int> entry in database)
            {
                Console.WriteLine($"Name: {entry.Key}\n" +
                    $"Party of {entry.Value}\n");
            }

        }
        
        public static void OutputTotalGuests(int numberOfGuests)
        {
            Console.WriteLine($"Total nubmer of attendees: {numberOfGuests}");
        }
    
    }

}
