// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int Sum(int min, int max)
{
    if (min == max) return max;
    
    return min + Sum(min + 1, max);
   
}

Console.WriteLine($"{Sum(min, max)}");

