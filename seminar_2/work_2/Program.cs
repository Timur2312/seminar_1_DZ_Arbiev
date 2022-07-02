
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Getnumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result >= 1 && result < 100000)
                break;
            else
            {
                Console.Clear();
                Console.WriteLine("Введи число от 1 до 10000");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Введи число от 1 до 10000");
        }
    }
    return result;
}

int ThirdNumber(int result)
{
    int thirdNumber = 0;
    while (true)
    {

        if (result < 100)
            Console.WriteLine("третьей цифры нет");
        if (result > 100 && result < 1000)
            thirdNumber = result % 10;
        else if (result > 1000 && result < 10000)
            thirdNumber = (result / 10) % 10;
        else if (result > 10000 && result < 100000)
            thirdNumber = (result / 100) % 10;
        break;
    }
    Console.WriteLine(thirdNumber);
    return thirdNumber;
}
int result = Getnumber("Введите число");
int thirdNumber = ThirdNumber(result);