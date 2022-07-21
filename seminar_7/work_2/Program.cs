// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

int[,] GetMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}
bool FindNumber(int[,] matrix, int find)
{
    bool result = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == find || j == find)
            {
                result = true;
                return result;
            }
        }
    }
    return result;
}
Console.WriteLine("Введите количетсов строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Какой индекс нужно найти в массиве");
int find = int.Parse(Console.ReadLine());
int[,] matrix = GetMatrix(m, n);
bool number = FindNumber(matrix, find);
if (number)
    Console.WriteLine($"Индекс {find} есть в массиве");
else
    Console.WriteLine($"Индекс числа {find} нет");