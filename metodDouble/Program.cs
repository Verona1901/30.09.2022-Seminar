

// Создание вещественных чисел

double[] CreateArrayRndDouble(int size, int min, int max)
{
var array = new double[size];
var rnd = new Random();

for (int i = 0; i < size; i++)
{
double rndNum = rnd.NextDouble() * (max - min) + min;
array[i] = Math.Round(rndNum, 2);

}
return array;
}


// Печать вещественных чисел
void PrintArrayDouble (double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}
