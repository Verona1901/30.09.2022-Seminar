﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;

    Console.WriteLine($"Последняя цифра числа => {lastDigit}");
}
else System.Console.WriteLine ("Число не трехзначное!");

