// Программа принимает на ввод два числа и проверяет, 
// является ли первое число квадратом второго
// a = 25, b = 5 -> yes, a = 2, b = 10 -> no, a = 9, b = 3 -> yes, a = -3, b = 5 -> no

Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);
if(number1 == number2 * number2)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{    
    Console.WriteLine("Первое число не является квадратом второго числа.");
}