// Рекурсия 
// семинар 9 
// ДЗ9

// Задача 64:
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// void ShowNums(int N)
// {
//    Console.Write(N +"  ");
//    if(N > 1) ShowNums(N - 1);
// }
// ShowNums(8);


Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// Console.Write("Input number M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int Sum (int M, int N)
// {
//    if(N == M) return N;
//    else 
//    return M + Sum(M + 1, N);

// }
// Console.Write($"{Sum (M,N)} ");



Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int A(int m, int n)
{
  if (m == 0)
    {
    return n + 1;
    }
    else 
    if (n == 0)
    {
    return A(m - 1, 1);
    }
    else
    return A(m - 1, A(m, n - 1));
}
int ACK = A(m,n);
Console.WriteLine($"{ACK} ");