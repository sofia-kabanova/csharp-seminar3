// 19. Напишите программу, которая 
// принимает на вход пятизначное число 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <9999 || num>99999) Console.Write("Вы ввели не пятизначное число. ");
else
{
void Rev(int n)
{
    int n1=n/10000;
    int n5=n%10;
    int n2=n/1000%10;
    int n4=n/10%10;
  if (n1==n5 && n2==n4) Console.Write($"Число {num} - палиндром. ");
  else Console.Write($"Число {num} -  не палиндром. ");
}
Rev(num);
}
