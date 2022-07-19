// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumber(string text)
{
    string erroMessage = "Вы ввели не верное число, введите верное число";
    Console.WriteLine(text);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else
        {
            Console.Clear();
            Console.WriteLine(erroMessage);
        }
    }
    return result;
}
int[] FillArray(int massArray)
{
    int[] arr = new int[massArray];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите эдемент массива под индексом {i} ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}
void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
}
void IsNumberMoreZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"{count} Количество значений которые больше 0");
}
int massArray = GetNumber("Введите количество чиссел массива");
int[] array = FillArray(massArray);
PrintArray(array);
IsNumberMoreZero(array);
