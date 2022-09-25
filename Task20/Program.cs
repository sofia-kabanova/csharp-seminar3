//20. Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7,21
// Решение:
// Ищем гипотенузу треугольника.
// квадрат гипотенузы равен сумме квадратов катета
// извлекаем квадрат из квадртата гипотенузы и округляем до сотых
Console.Clear();
Console.WriteLine("Введите координаты первой точки");
Console.Write("A1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй точки");
Console.Write("A2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
double Distance(int x1, int y1, int x2, int y2)
//делаем метод, тип данных double
{
double d=(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1); // сумма квадратов катета
return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);
//извлекаем квадрат и округляем результат до двух знаков после запятой
}
Console.WriteLine(Distance(a1, b1, a2, b2));
// выводит результат, 
//вызывая метод Distance для введенных пользователем данных