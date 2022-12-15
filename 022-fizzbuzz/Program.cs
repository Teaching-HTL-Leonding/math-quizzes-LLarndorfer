//*FizzBuzz

for (int i = 0; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        System.Console.Write("FizzBuzz ");
    }
    else if (i % 3 == 0)
    {
        System.Console.Write("Fizz ");
    }
    else if (i % 5 == 0)
    {
        System.Console.Write("Buzz ");
    }
    else 
    {
        System.Console.Write(i + " ");
    }
} 