﻿/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите положительное целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0) 
{
    int[] array = new int[N];
    for (int i=1; i <= N; i++) 
    {
        array[i-1] = (int)Math.Pow(i, 3);
    }
    Console.WriteLine(string.Join(", ", array));
}
else Console.WriteLine("Вы ввели что-то не то!");