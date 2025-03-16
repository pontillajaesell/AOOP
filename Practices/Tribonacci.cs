using System;
int Tribonacci(int n)
{
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 1;

        return Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
}

Console.Write("Enter Value for n: ");
int x = int.Parse(Console.ReadLine());

int value = Tribonacci(x);
Console.WriteLine($"Element {x} of the Tribonacci sequence is: {value}");
