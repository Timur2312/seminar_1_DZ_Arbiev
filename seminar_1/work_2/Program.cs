// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите Первое число");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int number_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Третье число");
int number_3 = int.Parse(Console.ReadLine());
int max = number_1;

if (max > number_2)
{
    Console.WriteLine($"Максимальное число {max}");
}
else
{
    max = number_2;
}
if (max > number_3)
{
    Console.WriteLine($"Максимальное число {max}");
}
else
{
    Console.WriteLine($"Максимальное число {number_3}");
}
