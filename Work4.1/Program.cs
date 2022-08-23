Console.Write("Введите возводимое в степень число: ");
string str1 = Console.ReadLine() ?? "";
Console.Write("Введите степень возведения: ");
string str2 = Console.ReadLine() ?? "";
int num1;
int num2;
double result = 0;

if(int.TryParse(str1, out num1))
{
    if(int.TryParse(str2, out num2))
    {
        result = Math.Pow(num1, num2);
        Console.WriteLine($"Результат = {result}");
    }
}
