// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

int[] GetArray()
{
    int[] array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}
int Summ(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        if (item % 2 != 0)
        {
            result = result + item;
        }
    }
    return result;
}
int[] array = GetArray();
PrintArray(array);
Console.WriteLine();
int summ = Summ(array);
Console.WriteLine(summ);