//18. Напишите программу, которая
// по заданному номеру четверти
// показывает диапазон
// возможных координат точек в этой четверти (x,y)
Console.Clear();
Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(quarter);
//создаем метод: тип int, если возвращаем числа, или string, если текст
string Quarter(int n)
{
 if (n==1) return "x> 0 и y>0";
 if (n==2) return "x< 0 и y>0";
 if (n==3) return "x< 0 и y<0";
 if (n==4) return "x> 0 и y<0";
 return "Некорректный номер четверти. Введите число от 1 до 4.";
}
// создаем переменную соответствующего типа, который возвращает наш метод, 
// и вызываем метод для фактических параметров
string result = Quarter(number);
Console.WriteLine(result);