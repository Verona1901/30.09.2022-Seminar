﻿// Задача 40: Напишите программу, которая
// 1. принимает на вход три числа и
// 2. проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32 (Console.ReadLine());
bool Triangle (int numA, int numB, int numC)
{
    return (numA< numB+numC && numB< numA+numC && numC<numA+numB);
}

bool triangle = Triangle (numberA, numberB, numberC);
if(triangle)Console.WriteLine("Треугольник со сторонами данной длины может существовать");
else Console.WriteLine("Треугольник со сторонами данной длины НЕ может существовать");