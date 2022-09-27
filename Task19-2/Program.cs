Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($" {num} --> ");
while ( num % 10 > 0 )
{
   Console.Write(num % 10);
   num /= 10;
} 
