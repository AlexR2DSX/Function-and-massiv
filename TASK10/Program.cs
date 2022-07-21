// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<10000)
Console.WriteLine("Третей чифры числа нет");
else
{
    while (num>=1000)
num=num/10;
Console.WriteLine("третья цыфра числа={0}",(num%10));
}