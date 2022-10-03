// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет



Console.Write ("Введите целое число1:");
int namber1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите целое число2:");
int namber2 = Convert.ToInt32 (Console.ReadLine());

if (namber1 == namber2 * namber2)
{
   Console.WriteLine ("Да");
}
else Console.WriteLine ("Нет");

// bool result = square == namber1 * namber2;
// int namber = Convert.ToInt32 (Console.ReadLine());
// int square = namber * namber;
// Console.WriteLine ($"Квадрат числа {namber} = {square}");