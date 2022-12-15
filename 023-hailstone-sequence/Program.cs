//*Hailstone sequence
int n = 0;
int length = 0;
int secn = 0;
int seclength = 0;
string longerlength = "";
while (n <= 0)
{
    System.Console.Write("Please enter your number: ");
    n = int.Parse(Console.ReadLine()!);
    if (n <= 0)
    {
        System.Console.WriteLine("You've entered something wrong. Please try again: ");
    }
}
while (secn <= 0)
{
    System.Console.Write("Please enter your number: ");
    secn = int.Parse(Console.ReadLine()!);
    if (secn <= 0)
    {
        System.Console.WriteLine("You've entered something wrong. Please try again: ");
    }
}

while (n > 1)
{
    if (n % 2 == 0)
    {
        n = n / 2;
    }
    else if (n % 2 != 0)
    {
        n = (3 * n) + 1;
    }
    length++;
}

while (secn > 1)
{
    if (secn % 2 == 0)
    {
        secn = secn / 2;
    }
    else if (secn % 2 != 0)
    {
        secn = (3 * secn) + 1;
    }
    seclength++;
}

if (length > seclength)
{
    longerlength = "Num 1";
}
else
{
    longerlength = "Num 2";
}
System.Console.WriteLine($"\nLength 1: {length}. Length 2: {seclength}.");
System.Console.Write($"Longer length was {longerlength}. \nSequence ends.");
