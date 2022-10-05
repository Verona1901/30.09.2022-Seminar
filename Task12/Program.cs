// 12. Напишите программу, которая
// 1. будет принимать на вход два числа
// 2.  и выводить, является ли второе число кратным первому.
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите целое число1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2:");
int number2 = Convert.ToInt32(Console.ReadLine());

int remains = number1 % number2;

if (remains == 0)
    Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно {remains}");