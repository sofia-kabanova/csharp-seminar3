// 22. Напишите программу, которая
// принимает на вход число N
// выдает таблицу квадратов чисел от 1 до N
// 2:
// 1  1
// 2  4
Console.Clear();
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int count =1;
if (num <=1) Console.Write("Диапазон для поиска квадратов не задан");
else
{
Console.WriteLine($"Число: Квадрат:");
void Square (int n, int c)
{
    while (c<=n)
    {
      Console.WriteLine($"{c,4} {c*c,6}");  
      c++;
    }
}
Square (num, count);
}
