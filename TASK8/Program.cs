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
