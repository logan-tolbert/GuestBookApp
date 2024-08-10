namespace GuestBookApp
{
    internal class Program
    {
        //Requirements
        //Build a Console Guest Book App. 
        //Ask the user for their name and how many are in their party.
        //Keep track of how many people are in their party and at the party as a whole
        //At the end, print out the quest list and the total number of guests
        static void Main(string[] args)
        {
            // Introduce app
            ConsoleMessages.AppIntro();

            // Get users name
            string userName = ConsoleMessages.GetUserName();
            Console.Clear();

            // Greet current user
            ConsoleMessages.GreetUser(userName);

            // Greet guests
            // Ask for guest/guests name 
            string guestName = ConsoleMessages.GetGuestName();

            // Ask for number of guest/guests
            int numberInParty = ConsoleMessages.GetNumberInParty();

            // Check if more guests are coming

            // Check list of names and print person/persons name the number in that party

            // Print total number of guests that attended the party
        }
    }
}
