// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели:");
int number1 = Convert.ToInt32(Console.ReadLine());
switch (number1)
{
    case 1:
        Console.WriteLine("понедельник");
        break;
    case 2:
        Console.WriteLine("вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("пятница");
        break;
    case 6:
        Console.WriteLine("суббота");
        break;
    case 7:
        Console.WriteLine("воскресенье");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}

//через оператор if
// Console.Write("Введите номер дня недели:");
// string num = Console.ReadLine ();
// if (num =="1")
// {
//    Console.WriteLine("понедельник"); 
// }
// else if (num == "2")
// {
//     Console.WriteLine("вторник");
// }
// else if (num == "3")
// {
//     Console.WriteLine("среда");
// }
// else if (num == "4")
// {
//     Console.WriteLine("четверг");
// }

// else if (num == "5")
// {
//     Console.WriteLine("пятница");
// }
// else if (num == "6")
// {
//     Console.WriteLine("суббота");
// }
// else if (num == "7")
// {
//     Console.WriteLine("воскресенье");
// }
// else 
// {
//     Console.WriteLine("Такого дня недели не существует!");
// }