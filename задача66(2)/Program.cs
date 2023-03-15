//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 
 
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}


int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);