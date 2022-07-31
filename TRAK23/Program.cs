// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

class Task {
static void Main() {
Console.WriteLine("Вывод таблицы кубов чисел от 1 до N");
Console.Write("Введите число N:");
string result = "";
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < a+1; i++){
    result += i*i*i;
        if (i != a){
        result += ", ";
    }
    }
Console.WriteLine(Convert.ToString(result));
}
}