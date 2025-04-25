Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.\n");
StartGame();

void StartGame()
{
    Console.WriteLine("Let's start the game!");
    Random random = new Random();
    int randomNum = random.Next(1, 101);
    bool isGame = true;
    int numOfAttempts = 0;

    while(isGame)
    {
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        numOfAttempts++;

        if (choice > randomNum)
        {
            Console.WriteLine($"Incorrect! The number is less than {choice}.");
        }
        else if (choice < randomNum)
        {
            Console.WriteLine($"Incorrect! The number is greater than {choice}.");
        }
        else
        {
            Console.WriteLine($"Congratulations! You guessed the correct number in {numOfAttempts} attempts.");
            isGame = false;
        }
    }
}