// Задание 6
// Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.WriteLine("Введите число: ");
//int number = ConverToInt32 (Console.Readline());
int number = 7;
if (number % 2 == 0)
{
    Console.WriteLine("Да четное ");
}
else Console.WriteLine("Нет нечетное ");