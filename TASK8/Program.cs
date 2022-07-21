//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

class Task {
static void Main() {
Console.WriteLine("Вывод всех чётных чисел до N");
Console.Write("Введите число N:");
string result = "";
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < a+1; i++){
if (i % 2 == 0){
if (i != 2){
result += ", ";
}
result += Convert.ToString(i);
}
}
Console.WriteLine(Convert.ToString(result));
}
}
