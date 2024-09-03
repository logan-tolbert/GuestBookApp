namespace ConsoleUI
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int numberOfGuests = 0;
            bool addGuests = true;
            GuestBook myGuestBook = new GuestBook();

            myGuestBook.GuestDatabase = new Dictionary<string, int>();

            ConsoleMessages.AppIntro();

            string userName = ConsoleMessages.GetUserName();
            Console.Clear();

            ConsoleMessages.GreetUser(userName);

            // TODO: Refactor into method 
            // TODO: Handle exception if duplicate name is passed
            do
            {
               
                string guestName = ConsoleMessages.GetGuestName();


                int numberInParty = ConsoleMessages.GetNumberInParty();
                numberOfGuests += numberInParty;

                myGuestBook.GuestDatabase.Add(guestName, numberInParty);

               
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

            ConsoleMessages.OutputGuestList(myGuestBook.GuestDatabase);
            ConsoleMessages.OutputTotalGuests(numberOfGuests);
        }
    }
}
