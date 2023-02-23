
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.WriteLine("Введите число: ");
int value = Convert.ToInt32(Console.Readline());
int a = value / 100;
int c = value % 10;
int b = value / 10 - a * 10;

System.Console.WriteLine(b);
