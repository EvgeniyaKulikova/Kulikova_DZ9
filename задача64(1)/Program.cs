// Задача 64(1) задайте значение м и n. напишите программу которая выведет все натуральные числа в промежутке от м до n.



void che(int m, int n)
{
    if (m > n)
    return;
    else
    {
        Console.Write($"{m}, ");
    }
    che(m+1,n);
    
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
che(m,n);



