//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)
//5 -> 2, 4
//8 -> 2, 4, 6

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        for (i=1; i<N; i++)
        {
          if (i % 2 == 0) 
          {
            Console.WriteLine(i);
          }
        }
    }      
}
