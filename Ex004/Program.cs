﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//    3 -> Среда 
//    5 -> Пятница
Console.WriteLine ("Введите день недели - число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine ("Понедельник");
}
if (number == 1)
{
   Console.WriteLine ("Вторник"); 
}
if (number == 3)
{
   Console.WriteLine ("Среда"); 
}
if (number == 4)
{
   Console.WriteLine ("Четверг"); 
}
if (number == 5)
{
   Console.WriteLine ("Пятница"); 
}
if (number == 6)
{
   Console.WriteLine ("Суббота"); 
}
if (number == 7)
{
   Console.WriteLine ("Воскресенье"); 
}