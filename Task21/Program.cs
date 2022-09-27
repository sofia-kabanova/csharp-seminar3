// 21.Напишите программу, которая 
// принимает на вход координаты двух точек
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты первой точки");
Console.Write("A1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("С1: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй точки");
Console.Write("A2: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("С2: ");
int c2 = Convert.ToInt32(Console.ReadLine());
double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
//делаем метод, тип данных double
{
double d=(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1); // сумма квадратов катета
return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);
//возващаем кубический корень и округляем результат до двух знаков после запятой
}
Console.WriteLine(Distance(a1, b1, a2, b2, c1, c2));
// выводит результат, 
//вызывая метод Distance для введенных пользователем данных