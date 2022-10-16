// Программа принимает на вход трёхзначное число и на выходе показывает последнюю
// цифру этого числа.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
// int n = number%10
Console.WriteLine("Остаток " + number%10);