/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int number = ReadInt("Введите число N: ");

Console.WriteLine(NaturalNumberMaxMin(number));

int NaturalNumberMaxMin(int n, int m=1)
{  
    if(m==n)
    return n;
    else
    {
     Console.Write(NaturalNumberMaxMin(n,m+1)+", ");
    }
    return m;
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}