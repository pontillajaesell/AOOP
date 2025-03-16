using System;

Console.Write("Enter principal amount: ");
double prAmnt = double.Parse(Console.ReadLine());

Console.Write("Enter rate of interest: ");
double rtInt = double.Parse(Console.ReadLine());

Console.Write("Enter time in years: ");
int time = int.Parse(Console.ReadLine());

double simpInt = (prAmnt * rtInt * time) / 100;

Console.WriteLine("Simple Interest: " + simpInt);
