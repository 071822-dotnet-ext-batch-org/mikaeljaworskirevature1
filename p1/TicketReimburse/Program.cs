using System;

namespace TicketReimburse
{
    class Program
    {

//TODO Write out the program to:
//   1) welcome the user. (200)
//   2) ask for user input of username (200)
//   3) check for username with the dbs methods; if true, welcome username, if false create new username.
//   4) if username is found, prompt for a password input; then check for password to match the db password. 
//      if not found, have them enter a new passwored directly after inputting new username.
//   5) have db input new user information and return a message.
//      log the user in automatically whether new or returning.
//   6) prompt user with choice -> 
//          -check ticket status (employees)
//          -create new ticket (employees)
//          -logout of the system (employees)
//          -check all open tickets (managers)
//          -update ticket status (managers)
//          -logout of the system (managers)
//   7) have system return the choice to the user and then either:
//          -collect information and send to db to return and print info to user
//          -collect information and update info on db then print message to user
//          -logout of system
//      reset the loop to command prompt upon task completion, UNLESS user logs out.

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tWelcome.\n\t\t\tAre you a returning user?\n\t\t\tEnter 1 for 'yes' and 2 for 'no'.");
            do
            {
                bool followeddirections  =  (Console.ReadLine());
                if(userinput == "1")
                {
                    Console.WriteLine("Please Enter Username and Password.");
                }

                else if(userinput == "2")
                {
                    Console.WriteLine("A new user has been found. Please enter your Username.");
                }

                else
                {
                    Console.WriteLine("Incorrect Input. Please try again.");  
                }
            } while(true);
        }
    }
}
