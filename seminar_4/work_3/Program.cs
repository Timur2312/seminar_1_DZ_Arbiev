// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33-> [6, 1, 33]
void FillArray(int[] array)
{
    Random rnd = new Random();
    foreach (int i in array)
    {
        array[i] = rnd.Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}
int[] array = new int[8];
FillArray(array);


