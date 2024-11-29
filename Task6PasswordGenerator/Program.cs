int n=0;
int l=0;
bool isNParsed = false;
bool isLParsed = false;

Console.WriteLine("Enter integer N: ");

while (!isNParsed)
{
    string nInput = Console.ReadLine();
    isNParsed = int.TryParse(nInput, out n) && n >= 1 && n <= 9;

    if (isNParsed)
    {
        break;
    }
    Console.WriteLine("Please, enter a number between 1 and 9");
}

Console.WriteLine("Enter integer L: ");

while (!isLParsed)
{
    string lInput = Console.ReadLine();
    isLParsed = int.TryParse(lInput, out l) && l >= 1 && l <= 9;

    if (isLParsed)
    {
        break;
    }
    Console.WriteLine("Please, enter a number between 1 and 9");
}

for (int s1 = 0; s1 <= n; s1++)
{
    for (int s2 = 0; s2 <= n; s2++)
    {
        for (int s3 = 0; s3 < l; s3++)
        {
            for (int s4 = 0; s4 < l; s4++)
            {
                for (int s5 = 0; s5 <= n; s5++)
                {
                    if (s5 > s1 && s5 > s2)
                    {
                        Console.Write($"{s1}{s2}{(char)('a' + s3)}{(char)('a' + s4)}{s5}" + " ");
                    }
                }
            }
        }
    }
}

