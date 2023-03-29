/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int b1, k1, b2, k2;


Console.Write($"Введите значение k1: ");
int.TryParse(Console.ReadLine(),out  b1);

Console.Write($"Введите значение k1: ");
int.TryParse(Console.ReadLine(),out  k1);

Console.Write($"Введите значение k2: ");
int.TryParse(Console.ReadLine(),out  b2);

Console.Write($"Введите значение b2: ");
int.TryParse(Console.ReadLine(),out  k2);



double x = (b2 - b1) / (k2 - k1);
double y = k1 * x + b1;

Console.Write($"координаты: {x}, {y}");