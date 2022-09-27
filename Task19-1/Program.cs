
// 19. Напишите программу, которая 
// принимает на вход число
// переворачивает его
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($" {num} --> ");
int num1 = num % 10;
int num2 = ((num/10) %10);
int num3 = ((num/100) %10);
int num4 = ((num/1000) %10);
Console.Write(num1);
Console.Write(num2);
Console.Write(num3);
Console.Write(num4);



    //while (num1 % 10 < 0)
    //{
      //  num1=num1 % 10;
        //num1=num1/10;
       // num1--;  
       // Console.Write(num1);
   // }

//if (num == num1) Console.Write($"{num} Да");
//else Console.Write("Нет");
