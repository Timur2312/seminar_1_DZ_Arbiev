// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
void SumRows(int[,] matrix, int m)
{
    int[] sum = new int[m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
        Console.WriteLine(sum[i]);
    }

}
Console.WriteLine("Введите количетсов строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество стобцов массива");
int n = int.Parse(Console.ReadLine());
int[,] matrix = GetMatrix(m, n);
SumRows(matrix, m);