// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber(int number)
{
    int res = 0;
    for (int i = 0; i < number; number = number / 10)
    {
        res = res + number%10;
    }
    return res;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("Введите число: ");
int rest = SumNumber(number);
Console.WriteLine("сумма цифр в введенном числе " + rest);