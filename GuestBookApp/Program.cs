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
            int numberOfPeople = 0;
            bool addGuests = true;
            GuestBook myGuestBook = new GuestBook();
            
            myGuestBook.GuestDatabase = new Dictionary<string, int>();
            // Introduce app
            ConsoleMessages.AppIntro();

            // Get users name
            string userName = ConsoleMessages.GetUserName();
            Console.Clear();

            // Greet current user
            ConsoleMessages.GreetUser(userName);

            // Greet guests
            // Ask for guest/guests name 
            do
            {
                // Ask for number of guest/guests
                string guestName = ConsoleMessages.GetGuestName();

                
                int numberInParty = ConsoleMessages.GetNumberInParty();
                numberOfPeople += numberInParty;

                myGuestBook.GuestDatabase.Add(guestName, numberInParty);

                // Check if more guests are coming

                bool moreGuests = ConsoleMessages.CheckForMoreGuests(); 
                if (moreGuests)
                {
                    continue;
                }
                else if (moreGuests == false)
                {
                    addGuests = false;
                }

            } while (addGuests);

            Console.Clear();

            // Check list of names and print person/persons name the number in that party
            foreach (KeyValuePair<string, int> entry in myGuestBook.GuestDatabase)
            {
                Console.WriteLine($"Name: {entry.Key}\n" +
                    $"Party of {entry.Value}\n");
            }

            // Print total number of guests that attended the party
            Console.WriteLine($"Total nubmer of attendees: {numberOfPeople}");  
        }
    }
}
