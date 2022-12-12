/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int n = ReadInt("Введите число N: ");
int m = ReadInt("Введите число M: ");

Console.WriteLine("-> " + Ack(n,m));

int Ack(int n, int m)
{
if (n ==0)
return m+1;
else
if ((n!=0)&&(m==0))
return Ack(n-1,1);
else 
return Ack(n - 1, Ack(n, m - 1));
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}