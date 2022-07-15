//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

public static class Program
{
    public static void Main()
    {
        Int32 k, l, m, n;
        Console.Write("m n: ");
        var s = Console.ReadLine().Split(" ");
        m = Convert.ToInt32(s[0]);
        n = Convert.ToInt32(s[1]);
        Random rnd = new Random();
        double[,] A = new double[m, n];
        for (k = 0; k < m; k++)
        {
            for (l = 0; l < n; l++)
            {
                A[k, l] = 20.0 * rnd.Next() / 2147483648 - 10.0;
                Console.Write(String.Format("{0,5:f1}",
                A[k, l]));
            }
            Console.WriteLine();
        }
    }
}