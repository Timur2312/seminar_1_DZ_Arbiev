// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
void GetNumber(string text)
{
    int number = 0;
    Console.WriteLine(text);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number)) break;
        else
        {
            Console.Clear();
            Console.WriteLine(text);
        }
    }
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    Console.WriteLine(sum);
}
GetNumber("Напишите число и получите сумму цифр в числе");
