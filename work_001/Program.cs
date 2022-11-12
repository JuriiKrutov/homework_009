// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void CountDawn(int num)
{
    if (0 < num)
    {
        System.Console.Write($"{num} ");
        CountDawn(num - 1);
    }
}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

CountDawn(num);
System.Console.WriteLine();