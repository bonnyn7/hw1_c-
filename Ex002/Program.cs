﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 5;
        int b = 7;

        int max = a;

        if (a > max) max = a;
        if (b > max) max = b;

        Console.Write("max= ");
        Console.WriteLine(max);
    }
}
