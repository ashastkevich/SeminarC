﻿Console.Clear();
Console.Write("Введите K1: ");
double K1 = double.Parse(Console.ReadLine());
Console.Write("Введите B1: ");
double B1 = double.Parse(Console.ReadLine());
Console.Write("Введите K2: ");
double K2 = double.Parse(Console.ReadLine());
Console.Write("Введите B2: ");
double B2 = double.Parse(Console.ReadLine());
double X = ((B1-B2) / (K2-K1));
double Y = (K1 * X + B1);
Console.WriteLine($"X = {X}, Y = {Y}");