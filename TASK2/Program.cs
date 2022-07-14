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