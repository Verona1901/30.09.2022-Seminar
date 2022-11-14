// Задача 63:
// 1. Задайте значение N.
// 2. Напишите программу, которая выведетвсе натуральные числа в промежутке от 1 до N.
//  N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num)
{
if(num == 0) return;
NaturalNumbers(num - 1);
Console.Write($"{num} ");

}

NaturalNumbers(number);