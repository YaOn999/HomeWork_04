// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double ExpNumber(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = EnterData("Введите первое число: ");
int b = EnterData("Введите второе число: ");
double exponentiation = ExpNumber(a, b);
Console.WriteLine($"если число {a} возвести в степень {b} получим {exponentiation}");