//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int numberA = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Введите число");
        int numberB = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Введите число");
        int numberC = Convert.ToInt32 (Console.ReadLine());

        int max = numberA;

        if (numberA > max) max = numberA;
        if (numberB > max) max = numberB;
        if (numberC > max) max = numberC;

        Console.Write("max= ");
        Console.WriteLine(max);
    }
}