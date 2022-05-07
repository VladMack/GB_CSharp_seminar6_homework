using System;
using System.Linq;

Console.Clear();

Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1 и  y = k2 * x + b2");
Console.WriteLine("Введи значения k1, b1, k2 и b2 через пробел:");
string[] vars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double k1 = int.Parse(vars[0]);
double b1 = int.Parse(vars[1]);
double k2 = int.Parse(vars[2]);
double b2 = int.Parse(vars[3]);
Console.WriteLine($"Точка пересечения двух прямых: {interFinder(k1, b1, k2, b2)}.");

string interFinder(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return $"({Math.Round(x, 3)}, {Math.Round(y, 3)})";
}