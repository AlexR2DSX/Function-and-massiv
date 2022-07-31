// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

class Task {
static void Main() {
Console.WriteLine("Проверка пятизначного числа, является ли оно палиндромом");
  Console.Write("Введите число:");
  int num = Convert.ToInt32(Console.ReadLine());
  bool poindrom = Convert.ToString(num % 10) + Convert.ToString(num / 10 % 10) == Convert.ToString(num / 1000);
  string res;
  if (poindrom)
     {
      res = "Да";
      }
     else
      {
      res = "Нет";
      }
Console.WriteLine(res);
}
}