// Задача 65: 
// 1.Задайте значения M и N. 
// 2.Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите целое число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num1, int num2)
{
    if (num1 == num2) Console.Write($"{num1} ");
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
}
NaturalNumbers(num1, num2);