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

int x = GetNumber("Введите первое число");
int y = GetNumber("Введите второе число");




