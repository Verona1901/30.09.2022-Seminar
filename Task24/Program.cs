﻿// Задача 24: Напишите программу, которая
// 1.принимает на вход число (А)
// 2. и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите число:");
string str = Console.ReadLine();
int number = Convert.ToInt32 (str);

int sumNumbers = SumNumbers (number);
Console.WriteLine($"Сумма числел от 1 до {number} = {sumNumbers}");
int SumNumbers (int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
      //sum = sum+i;
      sum +=i;  
    }
    return sum;
}