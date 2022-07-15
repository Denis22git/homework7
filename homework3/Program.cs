// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

int[,] array = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = i * j + 1;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < 4; i++)
{
    int summ = 0;
    for (int j = 0; j < 3; j++)
    {
        summ = summ + array[j, i];
    }
    double average = summ / 3;
    int n = i + 1;
    Console.WriteLine("Среднее значение " + n + " столбец " + average);
}