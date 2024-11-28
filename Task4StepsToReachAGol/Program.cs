int stepsCount = 0;
string goingHome = "going home";
int stepGoal = 10000;

while (stepsCount < stepGoal)
{
    Console.WriteLine("Number of steps: ");
    string userInput = Console.ReadLine();
    int stepsToAdd = 0;
    
    bool isNumber = int.TryParse(userInput, out stepsToAdd);

    if (isNumber)
    {
        stepsCount += stepsToAdd;
        if (stepsCount >= stepGoal)
        {
            Console.WriteLine($"You reached your goal with {stepsCount} steps! Great job!");
            break;
        }
        else
        {
            Console.WriteLine($"You added {stepsToAdd} steps to your total of {stepsCount}. Remaining: {stepGoal-stepsCount}");   
        }
    }
    else
    {
        if (userInput.ToLower().Equals(goingHome))
        {
            Console.WriteLine("How many steps did you make going home?");
            userInput = Console.ReadLine();
            isNumber = int.TryParse(userInput, out stepsToAdd);
            if (isNumber)
            {
                stepsCount += stepsToAdd;
                if (stepsCount >= 10000)
                {
                    Console.WriteLine($"You reached your goal with {stepsCount}! Great job!!!");
                    break;  
                }
                else
                {
                    Console.WriteLine($"You added {stepsToAdd} steps to your total of {stepsCount}. " +
                                      $"You finish the day with remaining: {stepGoal-stepsCount} steps to reach the goal");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid value");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid value");
        }
    }
}


