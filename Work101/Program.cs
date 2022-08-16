Console.Write("Введите трёхзначное число: ");
string str = Console.ReadLine() ?? "";
int number;
if(int.TryParse(str, out number))
{

    if(str.Length == 3)
    {
        Console.WriteLine(str[1]);
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}   
else
{
    Console.WriteLine("Ошибка ввода");
}
