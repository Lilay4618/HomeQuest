Console.WriteLine("Данная программа принимает число N, и выдаёт результат возведения в куб всех натуральных значений от 1 до N");
Console.Write("Введите значение N ");
string str = Console.ReadLine() ?? "";
int N;
int count = 1;
int result = 0;
if(int.TryParse(str, out N))
{
    while(count <= N)
    {
        result = count * count * count;
        Console.WriteLine($"{count} в 3-ей степени = {result}");
        count++;
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}