
int CheckNumber(int number)
{
    Console.WriteLine("Введите пяти значное число");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number >= 10000 && number <= 100000) break;
            else
            {
                Console.Clear();
                Console.WriteLine("Введите пяти значное число");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Введите пяти значное число");
        }
    }
    return number;
}
int number = 0;
int result = CheckNumber(number);
int oldNumber = result;
int newValue = 0;
while (result > 0)
{
    int dig = result % 10;
    newValue = newValue * 10 + dig;
    result = result / 10;
}
if (newValue == oldNumber) Console.WriteLine("да");
else
{
    Console.WriteLine("нет");
}


