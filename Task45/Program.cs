// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int[] Fibonacci(int number)
{
int[] array = new int[number];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < number; i++)
{
array[i] = array[i - 1] + array[i - 2];
}
return array;
}

int[] CopyArray(int[] arr)
{
int[] newArr= new int[arr.Length];
for (int i = 0; i < newArr.Length; i++)
{
newArr[i]=arr[i];
}
return newArr;
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

int[] arr = Fibonacci(num);
PrintArray(arr);
int[] newArr = CopyArray(arr);
PrintArray(newArr);

// 2 способ
// int[] CreateArrayRndInt(int size, int min, int max)
// {
// int[] array = new int[size];
// var rnd = new Random();
// for (int i = 0; i < size; i++)
// {
// array[i] = rnd.Next(min, max + 1);
// }
// return array;
// }

// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// if(i < array.Length - 1) Console.Write($"{array[i]}, ");
// else Console.Write($"{array[i]}");
// }
// Console.WriteLine("]");
// }

// int[] CopyArray(int[] array)
// {
// int[] newArray = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
// {
// newArray[i] = array[i];
// }
// return newArray;
// }

// int[] arr = CreateArrayRndInt(5, 0, 100);
// PrintArray(arr);

// int[] newArr = CopyArray(arr);
// newArr[0] = 5000;
// PrintArray(newArr);