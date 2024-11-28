// See https://aka.ms/new-console-template for more information

bool isTabsParsed = false;
int tabCount = 0;
bool isSalaryParsed = false;
int salaryCount = 0;
const string siteFacebook = "facebook";
const string siteInstagram = "instagram";
const string siteReddit = "reddit";
string typeOfSite = null;
int fineCount = 0;
int salaryDeduction = 0;
int remainingSalary = 0;

Console.WriteLine("Number of open tabs: ");

while (!isTabsParsed)
{
    string tabCountInput=Console.ReadLine();
    isTabsParsed = int.TryParse(tabCountInput, out tabCount) && tabCount >= 1 
                                                             && tabCount <= 10;
    if (isTabsParsed)
    {
        break;
    }
    Console.WriteLine("Please enter a number between 1 and 10: ");
}

Console.WriteLine("Salary: ");

while (!isSalaryParsed)
{
    string salaryInput = Console.ReadLine();
    isSalaryParsed = int.TryParse(salaryInput, out salaryCount) && salaryCount >= 700 
                                                                && salaryCount <= 1500;
    if (isSalaryParsed)
    {
        break;
    }
    
    Console.WriteLine("Please enter a number between 700 and 1500: ");
}

Console.WriteLine("Type of site: ");

while (typeOfSite != siteFacebook && typeOfSite != siteInstagram && typeOfSite != siteReddit)
{
    typeOfSite = Console.ReadLine().ToLower();
    switch (typeOfSite)
    {
        case siteFacebook:
            fineCount = 150;
            break;
        case siteInstagram:
            fineCount = 100;
            break;
        case siteReddit:
            fineCount = 50;
            break;
        default: 
            Console.WriteLine("Please enter a valid type of site ");
            break;
    }
}

salaryDeduction = tabCount * fineCount;
remainingSalary = salaryCount - salaryDeduction;

if (remainingSalary > 0)
{
    Console.WriteLine("Remaining salary: " + remainingSalary);
}
else
{
    Console.WriteLine("You have lost your salary.");
}