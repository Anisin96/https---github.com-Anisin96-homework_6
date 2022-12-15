// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int m = int.Parse(Console.ReadLine());
// int count = 0;

// for (int i = 0; i < m; i++)
// {
//     int enteredNumber = int.Parse(Console.ReadLine());
//     if (enteredNumber > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine("Пользователь ввёл " + count + " положительных чисел");

// Console.ReadLine();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

 Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = -1 * (b2 - b1) / (k2 - k1);
double y = k1 * x + b1;

Console.WriteLine($"Точки пересекутся в координатах ({x};{y})");
