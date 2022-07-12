
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
