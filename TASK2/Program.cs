//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа");
Console.Write("Первое число");
double a=Convert.ToDouble(Console.ReadLine());
Console.Write("Второе число");
double b=Convert.ToDouble(Console.ReadLine());
if(a>b)
{
Console.WriteLine("max="+Convert.ToString(a));
Console.WriteLine("min="+Convert.ToString(b));
}
if(b>a)
{
Console.WriteLine("max="+Convert.ToString(b));
Console.WriteLine("min="+Convert.ToString(a));
}
if(b==a)
{
    Console.WriteLine("Числа равны");
}