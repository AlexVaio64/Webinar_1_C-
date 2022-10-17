// Программа, которая на вход принимает два целых числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
if(a > b) 
{
        Console.WriteLine("max = " + a + " min = " + b);
}
else
{    
    Console.WriteLine("max = " + b + " min = " + a);
}