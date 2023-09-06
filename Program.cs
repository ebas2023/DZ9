/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine ("Введите число N:");
int Z =int.Parse (Console.ReadLine ()!);

Console.WriteLine ($"{Natur(Z,1)}");

string Natur(int N,int K)
{
    if(N==K) return K.ToString();
    return (N+","+ Natur(N-1,K));
   
}