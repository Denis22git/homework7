// Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет

int value;
Console.WriteLine("Введите число");
int[,] arr = new int[3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3}, 
    {8, 4, 2, 4}, 
};
int.TryParse(Console.ReadLine(), out value);
for (int i = 0; i < arr.Length / 4; i++)
{
    for (int j = 0; j < arr.Length / 3; j++)
    {
        if (arr[i, j] == value) Console.WriteLine("Индекс равен = [{0},{1}]", i, j);
    }
    
}