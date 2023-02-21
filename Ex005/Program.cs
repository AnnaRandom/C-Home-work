// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые 
// числа в промежутке от -N до N.
//   4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//  2 -> " -2, -1, 0, 1, 2"

// откуда N - задаем пользователь
// куда выводим результат - терминал

// 2. Алгоритм в Diagram.drawio.png
// 
int N;
//Console.Writeline("Введите N");
//N = int.Parse(Console.Readline[]);
N = 5;
int index;
index = -N;
while (index <= N)
{
    Console.Writeline (index + " ");
    index = index + 1;
}

Console.Writeline("END");