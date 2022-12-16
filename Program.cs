// (1) Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// (2) Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите номер задачи: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1) Task68();
else if(n == 2) Task66();

void Task68()  // (1)
{
    Console.Write("Введите число 1: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(A(m,n));
    int A(int m, int n)
    {
        if(m == 0)
            return n+1;
        else if(m>0 && n == 0)
            return A(m-1,1);
        else if(m>0 && n>0)
            return A(m-1,A(m,n-1));
        return A(m,n);    
    }
}

void Task66()  // (2)
{
    Console.Write("Введите число 1: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    if(m>0 && n>0)
        Sum(m,n,sum);
    else Console.WriteLine("Введите корректные числа");
    void Sum(int m, int n, int sum)
    {
        if(m > n)
        {
            Console.WriteLine(sum);
            return;
        }    
        sum = sum + m++;    
        Sum(m,n,sum);    
    }
}    