Console.WriteLine("Ппедите три числа");
Console.Write("Первое число");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Второе число");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Третье число");
double с = Convert.ToDouble(Console.ReadLine());
  if (a>b & a>c){
Console.WriteLine("max="+ Convert.ToString(a));
}
if (b>a & b>c)
{
Console.WriteLine("max="+ Convert.ToString(b));
}
if (c>a & c>b)
{
Console.WriteLine("max="+ Convert.ToString(c));
}