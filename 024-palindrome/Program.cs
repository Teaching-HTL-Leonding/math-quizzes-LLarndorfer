//*Palindrome
int usernum = 0;
int reversednumber = 0;
int savedusernum = 0;

while (usernum <= 0)
{
    System.Console.WriteLine("Please enter a positive integer number.");
    usernum = int.Parse(Console.ReadLine()!);
    savedusernum = usernum;
    if (usernum <= 0)
    {
        System.Console.WriteLine("You've entered something wrong. Please try again: ");
    }
}   
while (usernum > 0)
{
    reversednumber = reversednumber * 10 + usernum % 10;
    usernum /= 10;
}
System.Console.WriteLine(reversednumber);

if (reversednumber == savedusernum)
{
    System.Console.WriteLine("Your number is a Palindrome number.");
}
else
{
    System.Console.WriteLine("Your number is no Palindrome Number");
}
