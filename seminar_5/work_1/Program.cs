// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    Random rnd = new Random();
    foreach (var i in array)
    {
        array[i] = rnd.Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}
void ChekNumber(int[] array, string text)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"{text}, {count}");
}
int[] array = new int[4];
FillArray(array);
ChekNumber(array, "Количество чётных чисел в массиве");