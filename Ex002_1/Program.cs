//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int numberA = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Введите число");
        int numberB = Convert.ToInt32 (Console.ReadLine());

        int max = numberA;

        if (numberA > max) max = numberA;
        if (numberB > max) max = numberB;

        Console.Write("max= ");
        Console.WriteLine(max);
    }
}