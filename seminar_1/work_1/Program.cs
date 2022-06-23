/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3
*/

Console.WriteLine("Введите первое число");
int number_a = int.Parse(Console.ReadLine()); // запрашивет число у ползователя и переводит тип данных в числовой 
Console.WriteLine("Введите второе число");
int number_b = int.Parse(Console.ReadLine());

if (number_a > number_b)
{
    Console.WriteLine($"Число {number_a} больше чем {number_b}");
}
else if (number_a == number_b)
{
    Console.WriteLine($"Число {number_a} равно числу {number_b} ");
}
else
{
    Console.WriteLine($"Число {number_a} меньше числа {number_b} ");
}
