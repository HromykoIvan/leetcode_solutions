//Factorial, recursion
var num = 4;
var result = CalculateFactorial(num);
Console.WriteLine($"The factorial of the number {num} is {result}.");


int CalculateFactorial(int num)
{
    if (num == 1)
    {
        return 1;
    }

    return num * CalculateFactorial(num - 1);
}
