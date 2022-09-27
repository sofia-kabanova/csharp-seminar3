// 23. Напишите программу, которая
// принимает на вход число N
// выдает таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (num <= 1) Console.Write("Диапазон для поиска кубов не задан. ");
else
{
Console.WriteLine($"Число:  Куб:");
void Cube (int n, int c)
{
    while (c<=n)
    {
      Console.WriteLine($"{c,3} {c*c*c,6}");
      c++;
    }
}
Cube (num, count);
}
