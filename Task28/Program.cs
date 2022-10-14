// Задача 28: Напишите программу, которая
// 1.принимает на вход число N 
// 2. и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine());

int Factorial (int num)

{
   int fact =1;
   for (int i = 1; i <= num; i++)
   {
    fact = fact*i;
   }
    return fact;
}
int factorial = Factorial(number);
Console.Write($"Произведение чисел от 1 до  {number} => {factorial}");
