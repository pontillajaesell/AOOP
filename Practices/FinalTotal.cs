using System;

Console.Write("Enter an integer: ");
int num = int.Parse(Console.ReadLine());

while (num < 0)
{
    Console.Write("Enter another integer: ");
    num = int.Parse(Console.ReadLine());
}

if (num > 0)
{
    if (num % 2 == 0)
    {
        int total = num * num;
        Console.WriteLine("The number is even.");
        Console.WriteLine($"{total}");
    }
    else
    {
        int total = num * num * num;
        Console.WriteLine("The number is odd.");
        Console.WriteLine($"{total}");
    }
}
else if (num == 0)
{
    Console.WriteLine("Nothing happened.");
}
else
{
    Console.WriteLine("Invalid input...");
}
