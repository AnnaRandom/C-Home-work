
// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool palindromAdverseReader(long numC)
{
  if (numC < 0) return false;
  if (numC == 0) return true;
  string numAs = Convert.ToString(numC);
  return numAs.SequenceEqual(numAs.Reverse());
}
Console.Write("Введите число для проверки на палиндром: ");
long testMe = long.Parse(Console.ReadLine());

Console.Write("Результат: ");

Console.WriteLine(palindromAdverseReader(testMe));