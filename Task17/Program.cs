// 17. Напишите программу, которая
// на вход принимает точки (X и Y)
// причем Х ии Y не равны нулю
// выдает номер четверти плоскости
// в которой находится эта точка
Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
//создаем метод: тип int, если возвращаем числа, или string, если текст
string Quarter(int xc, int yc)
{
 if ( xc> 0 && yc>0) return "Первая четверть";
 if ( xc< 0 && yc>0) return "Вторая четверть";
 if ( xc< 0 && yc<0) return "Третья четверть";
 if ( xc> 0 && yc<0) return "Четвертая четверть";
 return "Введены некорректные координаты";
}
// создаем переменную соответствующего типа, который возвращает наш метод, 
// и вызываем метод для фактических параметров
string result = Quarter(x, y);
Console.WriteLine(result);
