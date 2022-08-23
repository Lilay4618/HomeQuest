Console.WriteLine("Введите число: ");
string str = Console.ReadLine() ?? "";
int x;
int.TryParse(str, out x);
int result = 0;
while(x > 0)
{
    result = result + x % 10;
    x = x / 10;
}
Console.WriteLine($"Результат: {result}");
