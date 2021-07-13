using System;
using System.Threading;
//how to keep up with how wins ??

// How to determine who wins?
//this is can be made by the numbers
//-----rock beat scissors
//-----paper beats rock
//-----scissor beats paper
//-----the same then do over


//use a random number generator for computer choice

//create and if else statement for which hand gesture to display

int PlayerScore = 0;
int ComputerScore = 0;

Main();

void Main()
{
    if (PlayerScore == 0 && ComputerScore == 0)
    {
        Console.WriteLine("Rock, Paper, Scissors for the fate of humanity! First to 3 wins...");
    }
    Scoreboard(PlayerScore, ComputerScore);
    if (PlayerScore == 3 && ComputerScore < 3)
    {
        Console.WriteLine("Game over! You saved humanity!");
        Thread.Sleep(4000);
        Environment.Exit(0);
    }
    if (PlayerScore < 3 && ComputerScore == 3)
    {
        Console.WriteLine("You blew it! Game over!");
        Thread.Sleep(4000);
        Environment.Exit(0);
    }
    int playerChoice = GamePrompt();
    int computerChoice = new Random().Next(1, 3);
    GameDisplay(playerChoice, computerChoice);
}

void Scoreboard(int pScore, int cScore)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine($"| Player: {pScore} | Computer: {cScore} |");
    Console.WriteLine("---------------------------");
}

int GamePrompt()
{
    Console.WriteLine("What's it gonna be?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    int playerChoice = 0;
    string playerInput = Console.ReadLine();
    if (playerInput == "4")
    {
        Console.WriteLine("Good choice. The only winning move is not to play...");
        Thread.Sleep(4000);
        Environment.Exit(0);
    }
    if (playerInput != "1" && playerInput != "2" && playerInput != "3")
    {
        Console.WriteLine("Come on, be serious!");
        Thread.Sleep(3000);
        Console.Clear();
        Main();
    }
    else
    {
        playerChoice = Int32.Parse(playerInput);
    }
    return playerChoice;
}

void GameDisplay(int player, int computer)
{
    Console.WriteLine(InputTranslator(player));
    Console.WriteLine("VS");
    Console.WriteLine(InputTranslator(computer));
    int result = GameLogic(player, computer);
    if (result == 3)
    {
        Console.WriteLine("Tie! Play again!");
        Thread.Sleep(3000);
        Console.Clear();
        Main();
    }
    else if (result == 1)
    {
        Console.WriteLine("Player wins! Down with the machines!");
        PlayerScore = PlayerScore + 1;
        Thread.Sleep(5000);
        Console.Clear();
        Main();
    }
    else if (result == 2)
    {
        ComputerScore = ComputerScore + 1;
        Console.WriteLine("Computer wins! Mankind is screwed!");
        Thread.Sleep(5000);
        Console.Clear();
        Main();
    }
}

string InputTranslator(int input)
{
    string result = "BLANK";
    switch (input)
    {
        case 1:
            result = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";
            break;
        case 2:
            result = @"      
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
      ";
            break;
        case 3:
            result = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
      ";
            break;
    }
    return result;
}

int GameLogic(int a, int b)
{
    int result = 0;
    if (a == b)
    {
        result = 3;
    }
    else if (a == 1 && b == 2)
    {
        result = 2;
    }
    else if (a == 1 && b == 3)
    {
        result = 1;
    }
    else if (a == 2 && b == 1)
    {
        result = 1;
    }
    else if (a == 2 && b == 3)
    {
        result = 2;
    }
    else if (a == 3 && b == 1)
    {
        result = 2;
    }
    else if (a == 3 && b == 2)
    {
        result = 1;
    }
    return result;
}





