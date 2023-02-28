// Groups of methods

void Method1()
{
 Console.WriteLine("Author...");   
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Text of message");
// Вид 2-1 - повторять определенное количество раз
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21 ( msg: "Tekst", count: 4);

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4
//string Method4(int count, string c)
//{
//int i = 0;
//string result = String.Empty;
//for(int i = 0; i < count; i++)
    //while (i < count)
    {
  //      result = result + c;
    //    i++;
    //}
    //return result;
//}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);

//for (int i = 2; i <=10; i++)
//{
   // for (int j = 2; j <=0; j++)
    //{
    //    Console.WriteLine ($"{i}*{j} = {i*j}");
    //}
    //Console.WriteLine();
//}

int[] array = { 1, 5, 4, 3, 2, 6,7, 1, 1 };
void PrintArray(int[] array)
{
    int  count = array.Length;
    for (int i = 0; i < count; i++)
    {
            Console.WriteLine ($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j <array.Length; j++)
        {
            if (array[j]< array[minPosition])
            {
                minPosition = j;
            }
        }
          int termporary = array[i];
          array[i] = array [minPosition];
          array[minPosition] = temporary;
    }
}
}
//PrintArray(arr);