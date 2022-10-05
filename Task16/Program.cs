// 16. Напишите программу, которая 
// 1.принимает на вход два числа
// 2. и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.Write("Введите целое число1:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите целое число2:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool CheckingNumders(int number1, int number2)
// {
//     int min = number1;
//     int max = number2;
//     if (number1 > number2)
//     {
//         min = number2;
//         max = number1;
//     }
//     return min * min == max;
// }
// bool result = CheckingNumders(num1, num2);
// if (result) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// Лучший спрособ:

Console.Write("Введите целое число1:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число2:");
int num2 = Convert.ToInt32(Console.ReadLine());

bool CheckingNumders(int number1, int number2)
{
    return number1* number1 == number2 ||number2* number2==number1;
}
if (CheckingNumders (num1, num2))Console.WriteLine("Да");
else Console.WriteLine("Нет");