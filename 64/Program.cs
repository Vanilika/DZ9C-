﻿//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

void Findnumber (int currIndex, int n)
{
    if (currIndex == n)
    return;
    System.Console.WriteLine(currIndex);
    Findnumber(--currIndex, n);
}
System.Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Bсе натуральные числа в промежутке от N до 1:");
 Findnumber(n, 0);
