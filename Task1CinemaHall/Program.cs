// See https://aka.ms/new-console-template for more information

string screeningType = null;
const string premier = "premier";
const string discount = "discount";
const string normal = "normal";
int rowNumber=0;
int columnNumber=0;
double pricePerTicket=0;
bool isRowParsed = false;
bool isColumnParsed = false;

Console.WriteLine("Type of screening: ");

while (screeningType != discount && screeningType != premier && screeningType != normal)
{
    screeningType = Console.ReadLine().ToLower();
    switch (screeningType)
    {
        case premier: 
            pricePerTicket = 12;
            Console.WriteLine($"The price of your ticket is {pricePerTicket} BGN.");
            break;
        case normal:
            pricePerTicket = 7.5;
            Console.WriteLine($"The price of your ticket is {pricePerTicket} BGN.");
            break;
        case discount:
            pricePerTicket = 5;
            Console.WriteLine($"The price of your ticket is {pricePerTicket} BGN.");
            break;
        default:
            Console.WriteLine("Please enter a valid screening type.");
            break;
    }    
}

Console.WriteLine("Row number: ");

while (!isRowParsed)
{
    string rowNumberInput = Console.ReadLine();
    isRowParsed = int.TryParse(rowNumberInput, out rowNumber) && rowNumber > 0;
    if (isRowParsed)
    {
        break;
    }
    
    Console.WriteLine("Please enter a valid row number.");
}

Console.WriteLine("Column number: ");

while (!isColumnParsed)
{
    string columnNumberInput = Console.ReadLine();
    isColumnParsed = int.TryParse(columnNumberInput, out columnNumber) && columnNumber > 0;
    if (isColumnParsed)
    {
        break;
    }
    
    Console.WriteLine("Please enter a valid column number.");
}

decimal result = Convert.ToDecimal(string.Format("{0:F2}", pricePerTicket * rowNumber * columnNumber));

Console.WriteLine($"The total revenue is {result} BGN.");


