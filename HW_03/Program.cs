// Напишите программу, которая задаёт массив из 8 
// элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     array[i] = new Random().Next(100);  
// }

// Console.WriteLine($"[{String.Join(",", array)}]");

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int size = EnterData("Введите размер массива: ");

int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100);  
}

Console.WriteLine($"[{String.Join(",", array)}]");