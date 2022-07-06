// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84

// A(7, -5, 0); B(1, -1, 9)-> 11.53

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не верное число";

    while (true)
    {
        Console.Clear();
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result)) // Преобразует полученное число из консоли из стрин в инт
        {
            if (result == 0)
                Console.WriteLine(errorMessage);

            else break;
        }
        else
            Console.WriteLine(errorMessage);
    }
    return result;
}

int x1 = GetNumber("Введите  X первого точки");
int y1 = GetNumber("Введите  Y первого точки");
int x2 = GetNumber("Введите  X второй точки");
int y2 = GetNumber("Введите  Y второй точки");
int x3 = GetNumber("Введите  X третьей точки");
int y3 = GetNumber("Введите  Y третьей точки");

double length = Math.Cbrt(Math.Pow(x3 - x2 - x1, 3) + Math.Pow(y3 - y2 - y1, 3));
Console.WriteLine($"Расстояние между точками {length}");




