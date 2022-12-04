// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (numA>=100 || numA<= -100)
{ 
    number = (numA%100)/10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}