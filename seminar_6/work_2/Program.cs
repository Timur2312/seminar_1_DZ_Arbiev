// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; 5,5)


double GetNumber(string text)
{
    var result = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else
        {
            Console.Clear();
            Console.WriteLine(text);
        }
    }
    return result;
}
void FindDot(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($"Пересечение в точке {x};{y}");
}
var b1 = GetNumber("Введите значения b1");
var k1 = GetNumber("Введите значения k1");
var b2 = GetNumber("Введите значения b2");
var k2 = GetNumber("Введите значения k2");
FindDot(b1, k1, b2, k2);
