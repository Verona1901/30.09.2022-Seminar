// Напишите программу, которая
// 1. Выводит число из отрезка [10,99]
// 2. и показывает наибольшую цифру числа.

int number= new Random (). Next (10,100);

Console.WriteLine ($"Случайное число из диапазона 10-99 -> {number}");
int firstDigint = number/10; //78/10=7
int secondDigint =number %10; //78%10 =8

if (firstDigint==secondDigint) Console.WriteLine ($"Цифры одинаковые");
else if (firstDigint > secondDigint) Console.WriteLine ($"Наибольшая цифра числа = {firstDigint}");
else Console.WriteLine ($"Наибольшая цифра числа = {secondDigint}");

// int res = Math.Max (firstDigint, secondDigint);
// Console.WriteLine ($"Наибольшая цифра числа = {res}");

