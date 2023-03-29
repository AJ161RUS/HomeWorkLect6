/*Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Write($"Ввод чисел: ");
string [] numbers = Console.ReadLine()!.Split(' ', ',' , ';', '.');

int [] array= new int[numbers.Length];

for (int i = 0; i < array.Length; i++)
    int.TryParse(numbers[i], out array[i]);
    for (int i = 0; i < array.Length; i++)
    Console.Write($" {array[i]} ");

    int Elem = 0;

for (int i = 0; i < array.Length; i++)

    if (array[i] > 0)
     
    Elem++;

    Console.Write($" Количество положительных чисел:  {Elem} ");

    return Elem;
     
    







