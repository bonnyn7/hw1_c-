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

        int max=0;
        int min=0;

        if (numberA > numberB)
        {
           max = numberA; 
           min = numberB;
           Console.Write("Максимальное число: ");
           Console.WriteLine(numberA);
           Console.Write("Минимальное число: ");
           Console.WriteLine(numberB);
        }
        else
        {
           max = numberB; 
           min = numberA;
           Console.Write("Максимальное число: ");
           Console.WriteLine(numberB);
           Console.Write("Минимальное число: ");
           Console.WriteLine(numberA);
        }
    }
}