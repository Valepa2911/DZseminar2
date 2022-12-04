// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA<=7)

    if (numA == 6 || numA == 7)
    Console.WriteLine("Выходной");
  else
    Console.WriteLine("Рабочий");

else

Console.WriteLine("Не номер дня недели");
