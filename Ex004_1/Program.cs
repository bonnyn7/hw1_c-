//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

internal partial class Program
{
    private static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        int c = 7;

        int max = a;

        if (a > max) max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        Console.Write("max= ");
        Console.WriteLine(max);
    }
}