// Программа выдаёт названия дней недели по заданному номеру.
// 3 -> Среда, 5 -> Пятница
Console.WriteLine("Введите цифру от 1 до 7: ");
int number1 = int.Parse(Console.ReadLine()!);

if((0 < number1) && (number1 < 8))
{
    if(number1 == 1) Console.WriteLine("Понедельник.");
    if(number1 == 2) Console.WriteLine("Вторник.");
    if(number1 == 3) Console.WriteLine("Среда.");
    if(number1 == 4) Console.WriteLine("Четверг.");
    if(number1 == 5) Console.WriteLine("Пятница.");
    if(number1 == 6) Console.WriteLine("Суббота.");
    if(number1 == 7) Console.WriteLine("Воскресенье.");
}
else
{
    Console.WriteLine("вы ввели неверное число.");
}