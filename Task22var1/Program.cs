// 22. Напишите программу, которая
// принимает на вход число N
// выдает таблицу квадратов чисел от 1 до N
// 2:
// 1  1
// 2  4
Console.Clear();
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <=1) Console.Write("Диапазон для поиска квадратов не задан");
else Console.WriteLine($"Вывожу квадраты чисел в диапазоне от 1 до {n}:");
Console.WriteLine($"Число: Квадрат:");
int count=1;
while (count<=n) 
{
    Console.WriteLine($"{count,3}{count*count,7}");
    count ++;
}
