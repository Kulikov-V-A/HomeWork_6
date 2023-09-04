/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
int CountNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int count = CountNum("Введите количество чисел: ");
int even = 0;
for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Введите число: ");
        int num = int.Parse(Console.ReadLine()!);
            if (num > 0) even ++;
    Console.WriteLine (even);   
    }
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


double VariablesNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


double CrossPoint1(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CrossPoint2(double k1, double x, double b1)
{
    double y = k1 * x + b1;
    return y;
}


double b1 = VariablesNum("Введите b1: ");
double k1 = VariablesNum("Введите k1: ");
double b2 = VariablesNum("Введите b2: ");
double k2 = VariablesNum("Введите k2: ");

double first = CrossPoint1(b1, k1, b2, k2);
double second = CrossPoint2(k1, first, b1);
Console.WriteLine($"Координаты точки пересечения прямых равна: {first}, {second}.");

