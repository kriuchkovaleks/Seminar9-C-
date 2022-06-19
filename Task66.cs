/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/






int GetNaturalSum(int M, int N) // commit
{
    if (M == N) return M;
    
    return GetNaturalSum(M, N -1) + N;
       
}

Console.WriteLine("Input M");
int M = int.Parse(Console.ReadLine());


Console.WriteLine("Input N");
int N = int.Parse(Console.ReadLine());
int summ = 0;

int result = GetNaturalSum(M, N);

Console.WriteLine(result);
