Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
MenuSelection();

void MenuSelection()
{
    bool isMenu = true;

    do
    {
        Console.WriteLine();
        Console.WriteLine("Please select the difficulty level:");
        Console.WriteLine("1. Easy (10 chances)");
        Console.WriteLine("2. Medium (7 chances)");
        Console.WriteLine("3. Hard (5 chances)");
        Console.WriteLine("4. Exit\n");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                StartGame("Easy", 10);
                break;
            case 2:
                StartGame("Medium", 7);
                break;
            case 3:
                StartGame("Hard", 5);
                break;
            case 4:
                isMenu = false;
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    } while (isMenu);
}

void StartGame(string difficulty, int chances)
{
    Random random = new Random();
    int randomNum = random.Next(1, 101);
    bool isGame = true;
    int numOfAttempts = 0;

    Console.WriteLine($"Great! You have selected the {difficulty} difficulty level.");
    Console.WriteLine($"You have {chances} chances to guess the correct number.");
    Console.WriteLine("Let's start the game!\n");

    while (isGame)
    {
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        numOfAttempts++;

        if (choice > randomNum)
        {
            Console.WriteLine($"Incorrect! The number is less than {choice}.\n");
        }
        else if (choice < randomNum)
        {
            Console.WriteLine($"Incorrect! The number is greater than {choice}.\n");
        }
        else
        {
            Console.WriteLine($"Congratulations! You guessed the correct number in {numOfAttempts} attempts.");
            isGame = false;
        }

        if (numOfAttempts > chances)
        {
            Console.WriteLine("Game over! You exceeded the number of attempts.");
            Console.WriteLine($"The number is: {randomNum}");
            isGame = false;
        }
    }
}

Console.WriteLine("Goodbye.");