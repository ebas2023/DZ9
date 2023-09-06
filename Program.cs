﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма равна={A(n, m)}");

int A(int n, int m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}


