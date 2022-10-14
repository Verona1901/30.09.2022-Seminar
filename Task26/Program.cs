// Задача 26: Напишите программу, которая
// 1. принимает на вход число
// 2. и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int NumbersCount (int num)
{
    int count =0;
    while (num >0)
    {
        num/=10;
        count++;
    }
    return count;
}
int numbersCount = NumbersCount(number);
Console.Write($"Количество цифр в числе {number} => {numbersCount}");