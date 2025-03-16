using System;

Console.Write("Enter N: ");
int num = int.Parse(Console.ReadLine());

int product = 1;
while (num > 0)
{
    int digit = num % 10;
    if (digit !=0)
    {
        product *= digit;
    }
    num /= 10;
}

Console.Write($"Digit product: {product}");
