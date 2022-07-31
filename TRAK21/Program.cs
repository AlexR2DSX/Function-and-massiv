// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

class Task {
static void Main() {
Console.WriteLine("Вывод расстояния между ними в 3D пространстве.");
  Console.Write("Введите коордтнату x 1 точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите коордтнату y 1 точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите коордтнату z 1 точки:");
int z1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите коордтнату x 2 точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите коордтнату y 2 точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите коордтнату z 2 точки:");
int z2 = Convert.ToInt32(Console.ReadLine());
  double length = Math.Pow((Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),0.5);
Console.WriteLine(Convert.ToString(length));
}
}