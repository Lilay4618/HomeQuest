Console.WriteLine("Приветствую! Данная программа позволяет вывести третью цифру заданного числа. Пожалуйста, следуй инструкциям, указанным ниже :)");
Console.Write("Введите числовое значение: ");
string str = Console.ReadLine() ?? "";
int number;
if(int.TryParse(str, out number))
{

    if(str.Length >= 3)
    {
        Console.WriteLine(str[2]);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}   
else
{
    Console.WriteLine("Ошибка ввода! Введите числовое значение.");
}
