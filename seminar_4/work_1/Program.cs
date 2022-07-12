// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else
        {
            Console.WriteLine(text);
        }
    }
    return result;
}
void PrintResult(int firstNumber, int secondNumber)
{
    double result = 1;
    for (int i = 1; i <= secondNumber; i++)
    {
        result = result * firstNumber;
    }
    Console.WriteLine(result);
    // double result = Math.Pow(firstNumber, secondNumber);
    // Console.WriteLine(result);
}
int firstNumber = GetNumber("Введите первое число");
int secondNumber = GetNumber("Введите в какую степень возвести первое число");
PrintResult(firstNumber, secondNumber);