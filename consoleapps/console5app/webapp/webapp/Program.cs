using System;

namespace webapp
{
    class Program
    {
        static void Main(string[] args)
        {
                //Welcome message
        Console.WriteLine("Welcome to a game of Rock, Paper, Scissors, Lizard, Spock!");

               //Instructions to play... explanation of the game flow. which keys are used, etc
        Console.WriteLine("Press the number corresponding to Rock, Paper, Scissors, Lizard, or Spock.\nThe Computer will make its choice and the winner shall be announced.\n Can you outsmart the computer?\nTo play, press Enter.");

               //start the game...by pressing ENTER
        Console.ReadLine();


               // (unseen to the user) create some variables to store which choice the user made, 
               //computer choice, computer wins, user wins, number of ties, player1 name (user), player 2 name (computer for now)
        int computerChoice = 0;
        Random rand = new Random(); //the random class gets a pseudorandom decimal b/n 0 and 1
        int playerChoice = -1;
        string playerChoiceStr = "";
        int playerWins = 0;
        int computerWins = 0;
        int numberOfTies = 0;
        string player1name = "";
        bool successfullConversion = false;
        bool isTie = true;
        string playagain = "";

               //get the users name
        Console.WriteLine("What is your name?");
        player1name = Console.ReadLine();

        Console.WriteLine($"Welcome to R-P-S-L-S, {player1name}");

                //a while loop for the tie scenario
        while(true){
        
        while(isTie)
        {


               //get the users choice

        Console.WriteLine("Choose your Weapon.\n\t1 for Rock\n\t2 for Paper\n\t3 for Scissors\n\t4 for Lizard\n\t5 for Spock.");
        playerChoiceStr = Console.ReadLine();

        successfullConversion = Int32.TryParse(playerChoiceStr, out playerChoice);

        
                //REMEMBER TO VALIDATE the User's Input
        

               //get the computers random choice
            
    
        computerChoice = rand.Next((1000)% 6)+1;
        Console.WriteLine(computerChoice);

               //evaluate the choices to determine the winner of the round
        if (computerChoice == playerChoice){
            Console.WriteLine($"Error. Computer and {player1name} have the same idea.\nPlease stop thinking like computer.");
            numberOfTies++;
   

            //tell them it was a tie.
        }

        else if (playerChoice == 1 && computerChoice == 3 || 
                playerChoice == 1 && computerChoice == 4 ||
                playerChoice == 2 && computerChoice == 1 ||
                playerChoice == 2 && computerChoice == 5 ||
                playerChoice == 3 && computerChoice == 2 ||
                playerChoice == 3 && computerChoice == 4 ||
                playerChoice == 4 && computerChoice == 2 ||
                playerChoice == 4 && computerChoice == 5 ||
                playerChoice == 5 && computerChoice == 1 ||
                playerChoice == 5 && computerChoice == 3)
        {
           Console.WriteLine($"Wow {player1name}. You are actually smarter than computer.");
            //playerWins = playerWins + 1;
            //playerWins += 1;
            playerWins ++;
            //if user wins

            isTie = false;
        }
        
        else
        {
           Console.WriteLine($"Expected. {player1name} is not smarter than computer."); //if user wins
            computerWins++;

            isTie = false;
            //if computer wins
        }


          Console.WriteLine($"Shall we play again?\nEnter 'Y' to play and 'N' to quit."); 
          playagain = Console.ReadLine();
          if(playagain == "Y" || String.Equals("Y", playagain, StringComparison.OrdinalIgnoreCase))
                {
                Console.WriteLine($"Let's Begin.");
                         isTie = true;
                }
          else
                {
                    //continue; //will end the current loop and immediately start the next iteration of the next loop
                    Console.WriteLine("Computer shall await your return.");
                    break; //will break the current loop.

                }
                
            } 
        
        }        //we know:
                // 1 == rock 2 == paper 3 == scissors 4 == lizard 5 == spock





               //tell them who won, computer or user, if there's a winner
               // ask them to make another choice if it was a tie (loop up to 'get the user choice')


               //ask if they want to play again (if using rounds, each game would need to be stored.)


               //update the tally for this gaming session if they choose play again; number of games computer won and number of games user won.


               //tell the user the tally results as of now


               //ask if they want to play again (keep the tally if they choose play again)


               //quit if they don't want to play... loop up if they DO want to play again


              

        
        }
    }
}   
