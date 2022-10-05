// 11. Напишите программу, которая
// 1. выводит случайное трёхзначное число
// 2. и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);

// Console.WriteLine($"Случайное число из диапазона 100-999 -> {number}");
// int firstDigint = number / 100; //456/100=4
//     int secondDigint = number % 10;  //456%10 =6
//     int twoNumber = firstDigint*10+secondDigint;
//     Console.WriteLine($"Две цифры = {twoNumber}");


//С применением метода
    int number = new Random().Next(100, 1000);

Console.WriteLine($"Случайное число из диапазона 100-999 -> {number}");
int NumberPrint (int num)
{
int firstDigint = num / 100; //456/100=4
    int secondDigint = num % 10;  //456%10 =6
    return firstDigint*10+secondDigint;
}
    Console.WriteLine($"Две цифры {number} => {NumberPrint (number)}");

