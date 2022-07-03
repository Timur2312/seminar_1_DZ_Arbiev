// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");
string day = Console.ReadLine();
if (day == "1")
    Console.WriteLine("День не выходной");
else if (day == "2")
    Console.WriteLine("День не выходной");
else if (day == "3")
    Console.WriteLine("День не выходной");
else if (day == "4")
    Console.WriteLine("День не выходной");
else if (day == "5")
    Console.WriteLine("День не выходной");
else if (day == "6")
    Console.WriteLine("Выходной");
else if (day == "7")
    Console.WriteLine("Выходной");
else
    Console.Write("Такого дня нет");