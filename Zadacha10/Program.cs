// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int number = 0;
if (numA < 100 || numA > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{   
    number = (numA%100)/10;
    Console.WriteLine(number);
}