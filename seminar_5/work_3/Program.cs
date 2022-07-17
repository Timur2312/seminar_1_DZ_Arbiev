// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray()
{
    Random rnd = new Random();
    double[] array = new double[10];
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);
        Console.Write($"{array[i]} | ");
    }
    return array;
}
double Summ(double[] array)
{
    double min = 0;
    double max = 0;
    double result = 0;
    foreach (var item in array)
    {
        min = item;
        max = item;
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }
        result = max - min;
    }
    Console.WriteLine(min);
    Console.WriteLine(max);
    return result;
}

double[] array = GetArray();
Console.WriteLine();
double result = Summ(array);
Console.WriteLine(result);



// double[] GetArray()
// {
//     Random rnd = new Random();
//     double[] array = new double[10];
//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(rnd.NextDouble() * 100, 1);
//         Console.Write($"{array[i]} | ");
//     }
//     return array;
// }
// double Summ(double[] array)
// {
//     double min = 100; /// Я так понял что это работает только если массив имеет не более чем 100 элементов, а вот как сделать чтобы было универсально для любого кол-во?
//     double max = 0;
//     double result = 0;
//     for (var i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];
//     }
//     result = max - min;
//     Console.WriteLine(max);
//     Console.WriteLine(min);
//     return result;

// }
// double[] array = GetArray();
// Console.WriteLine();
// double result = Summ(array);
// Console.WriteLine(result);
