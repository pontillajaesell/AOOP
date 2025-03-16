using System;

Console.Write("Enter the diameter of the sphere: ");
double num = double.Parse(Console.ReadLine());

double sa = 4 * Math.PI * Math.Pow(num, 2);
double vol = (4 / 3) * Math.PI * Math.Pow(num, 3);

Console.WriteLine($"Surface Area: {sa:F2}");
Console.Write($"Volume: {vol:F2}");
