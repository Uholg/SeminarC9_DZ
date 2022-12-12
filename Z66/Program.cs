/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int number1 = ReadInt("Введите число M: ");
int number = ReadInt("Введите число N: ");

if (number1>number)
{
    int temp=number1;
    number1=number;
    number=temp;
}
Console.WriteLine("-> " + NaturalNumberSum(number1,number));

int NaturalNumberSum(int m, int n)
{
    if(n==m)
    return m;
    else
    {
     return NaturalNumberSum(m,n-1)+n;
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
