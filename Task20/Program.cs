﻿// Задача 20: Напишите программу, которая
// 1.принимает на вход координаты двух точек
// 2. и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты X точки A:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B:");
int yb = Convert.ToInt32(Console.ReadLine());

double distance =Math.Round (Distance (xa, ya, xb, yb),2, MidpointRounding.ToZero);
Console.WriteLine ($"Расстояние от точки А до точки В: {distance}");

double Distance (int x1,int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow ((x2-x1),2)+ Math.Pow ((y2-y1),2));
    return res;
}