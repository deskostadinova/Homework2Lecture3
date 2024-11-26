// See https://aka.ms/new-console-template for more information

string screeningType = null;
const string premier = "premier";
const string discount = "discount";
const string normal = "normal";
int rowNumber;
int columnNumber;
double pricePerTicket=0;
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
rowNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Column number: ");
columnNumber = int.Parse(Console.ReadLine());

decimal result = Convert.ToDecimal(string.Format("{0:F2}", pricePerTicket * rowNumber * columnNumber));

Console.WriteLine($"The total revenue is {result} BGN.");


