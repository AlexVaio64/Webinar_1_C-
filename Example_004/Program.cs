// Программа принимает на вход одно число (N), а на выходе показывает все
// целые числа в промежутке от -N до N.

Console.WriteLine("Введите любое целое число: ");
int N = int.Parse(Console.ReadLine()!);
int M = N * (-1);

if (N < 0)
{
    int temp = N;
    N = M;
    M = temp;
}
    while (M <= N)
{
    Console.Write(M + " ");
    M = M + 1;
}