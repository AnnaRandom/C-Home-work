 // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 10;
int b = 5;
int max = a;
if (a > b)
{
    max = a;
}
else max = b;
Console.Write ( "максимум из двух чисел:" );
Console.WriteLine (max);