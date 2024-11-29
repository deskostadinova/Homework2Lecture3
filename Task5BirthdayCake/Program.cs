int cakeLength = 0;
int cakeWidth = 0;
bool isLenghtValid = false;
bool isWidthValid = false;
int eatenCakeCount=0;


while (!isLenghtValid)
{
    Console.WriteLine("Cake length: ");
    string lenghtInput=Console.ReadLine();
    isLenghtValid = int.TryParse(lenghtInput, out cakeLength) && cakeLength >= 1 
                                                             && cakeLength <= 1000;
    if (isLenghtValid)
    {
        break;
    }
    Console.WriteLine("Please enter a number between 1 and 1000: ");
}

while (!isWidthValid)
{
    Console.WriteLine("Cake width: ");
    string widthInput=Console.ReadLine();
    isWidthValid = int.TryParse(widthInput, out cakeWidth) && cakeWidth >= 1 
                                                              && cakeWidth <= 1000;
    if (isWidthValid)
    {
        break;
    }
    Console.WriteLine("Please enter a number between 1 and 1000: ");
}

int piecesCount = cakeLength * cakeWidth;
Console.WriteLine($"The pieces of the cake are {piecesCount}.");

while (eatenCakeCount < piecesCount)
{
    Console.WriteLine("Number of eaten pieces: ");
    string eatenPiecesInput=Console.ReadLine();
    int piecesToAdd = 0;
    bool isNumber = int.TryParse(eatenPiecesInput, out piecesToAdd);
    int totalEatenPieces = eatenCakeCount + piecesToAdd;
    
    if (isNumber)
    {
        eatenCakeCount += piecesToAdd;
        if (totalEatenPieces > piecesCount)
        {
            Console.WriteLine($"No more cake left! You need {totalEatenPieces - piecesCount} more.");
            break;
        }
        else if (totalEatenPieces == piecesCount)
        {
            Console.WriteLine("No more cake left!");
            break;
        }
        else
        {
            Console.WriteLine($"Remaining pieces: {piecesCount-totalEatenPieces}");
        }
    }
    else
    {
            if (eatenPiecesInput.ToUpper().Equals("STOP"))
            {
                Console.WriteLine($"The number of pieces left is {piecesCount-totalEatenPieces}.");
                break;
            }
    }
}
