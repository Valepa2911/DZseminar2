// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA%numB == 0)
     Console.WriteLine("Является квадратом");
else
    Console.WriteLine("Не является квадратом");     