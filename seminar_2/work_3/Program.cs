// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
int day = int.Parse(Console.ReadLine());
if (day >= 1 && day <= 1)
    Console.WriteLine("Будний");
if (day < 5 && day > 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Ввели чушь");