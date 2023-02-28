
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
   return (num % 100) / 10;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99 && number<1000)
{
   int result = SecondDigit(number);
   Console.WriteLine(result);
}
else
{
   Console.WriteLine("Число не трёхзначное");
}