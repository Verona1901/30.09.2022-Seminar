// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write ("Введите целое число:");
int namber = Convert.ToInt32 (Console.ReadLine());
int square = namber * namber;
Console.WriteLine ($"Квадрат числа {namber} = {square}");

// double d = default;
// string str = default;
// bool b = default;
// int num = default;

// Console.WriteLine (d);
// Console.WriteLine (str);
// Console.WriteLine (b);
// Console.WriteLine (num);