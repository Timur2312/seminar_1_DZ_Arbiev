// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3-> 1, 8, 27
// 5-> 1, 8, 27, 64, 125


int GetNumber(string text)
{
    int number = 0;

    while (true)
    {
        Console.Clear();
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out number)) break;
        else
        {
            Console.WriteLine(text);
        }
    }
    return number;
}
void Sqrt(int result)
{
    for (int i = 1; i < result; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
int result = GetNumber("Введиче число");
Sqrt(result);
