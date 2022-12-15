//*Finding the operator
//*Lukas Larndorfer
//*01-12-2022
string op = "";
System.Console.WriteLine("Please enter the first Operand: ");
float firstoperand = float.Parse(Console.ReadLine()!);
System.Console.WriteLine("Please enter the second Operand: ");
float secondoperand = float.Parse(Console.ReadLine()!);
System.Console.WriteLine("Please enter the result: ");
float result = float.Parse(Console.ReadLine()!);

if (firstoperand * secondoperand == result)
{
    op = "Multiply";
}
if (firstoperand - secondoperand == result || secondoperand - firstoperand == result)
{
    op = "Minus";
}
if (firstoperand + secondoperand == result)
{
    op = "Plus";
}
if (firstoperand / secondoperand == result || secondoperand / firstoperand == result)
{
    op = "Divide";
}
if (Math.Pow(firstoperand, secondoperand) == result || Math.Pow(secondoperand, firstoperand) == result)
{
    op = "Exponentiation";
}
if (firstoperand % secondoperand == result || secondoperand % firstoperand == result)
{
    op = "Modulo";
}
System.Console.WriteLine("This is the possible operator for your number: " + op);