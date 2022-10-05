// 14. Напишите программу, которая
// 1. принимает на вход число
// 2. и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


// bool CheckingNumder(int number, int div1, int div2)
// {
//     return number % div1 == 0 && number % div2 == 0;
// }
// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = CheckingNumder(num, 7, 23);
// if (result)
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }

// Еще способ
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool Remains(int a, int b)
{
    return a % b == 0;
}
if (Remains(number, 7) && Remains(number, 23))

    Console.Write("Да");
else

    Console.Write("Нет");