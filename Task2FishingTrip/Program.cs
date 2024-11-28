// See https://aka.ms/new-console-template for more information

int groupBudget=0;
string seasonName = null;
const string spring = "spring";
const string summer = "summer";
const string autumn = "autumn";
const string winter = "winter";
int fishermen = 0;
double rentalCost = 0;
double discount = 0;
bool isFishermenNumberValid = false;
bool isBudgetParsed = false;

Console.WriteLine("Your budget: ");
while (!isBudgetParsed)
{
    string budgetInput = Console.ReadLine();
    isBudgetParsed = int.TryParse(budgetInput, out groupBudget) && groupBudget > 0 
                                                                && groupBudget <= 8000;
    if (isBudgetParsed)
    {
        break;
    }
    
    Console.WriteLine("Please enter a valid budget between 1 and 8000 BGN.");
}

Console.WriteLine("Season: ");

while (seasonName != "spring" && seasonName != "summer" && seasonName != "autumn" 
                                                        && seasonName != "winter")
{
    seasonName = Console.ReadLine().ToLower();
    switch (seasonName)
    {
        case spring: 
            rentalCost = 3000;
            break;
        case summer:
            rentalCost = 4200;
            break;
        case autumn:
            rentalCost = 4200;
            break;
        case winter:
            rentalCost = 2600;
            break;
        default: 
            Console.WriteLine("Please, enter a valid season: ");
            break;
    }
}
Console.WriteLine("Number of fishermen: ");

while (!isFishermenNumberValid)
{
    isFishermenNumberValid = int.TryParse(Console.ReadLine(), out fishermen) && fishermen >= 4 
                                                                               && fishermen <= 18;
    if (!isFishermenNumberValid)
    {
        Console.WriteLine("Please, enter a valid number between 4 and 18: ");
        continue;
    } else if (fishermen >= 4 && fishermen <= 6)
    {
        discount = 0.1;
        break;
    }
    else if (fishermen >= 7 && fishermen <= 11)
    {
        discount = 0.15;
        break;
    }
    else if (fishermen >= 12 && fishermen <= 18)
    {
        discount = 0.20;
        break;
    }
}
Console.WriteLine($"Discount: {discount*100}%");
rentalCost = rentalCost * (1 - discount);
if (!(seasonName.Equals(autumn)) && fishermen % 2 == 0)
{
    rentalCost = rentalCost * (1 - 0.05);
    Console.WriteLine("You have additional 5% discount.");
}
Console.WriteLine($"Rental Cost is {rentalCost:F2}");

if (groupBudget >= rentalCost)
{
    Console.WriteLine("Your budget is covering the rental cost.");
}
else
{
    {
        Console.WriteLine("Your budget is not covering the rental cost.");
    }
}




