Console.WriteLine("Приветствую! Данная программа позволяет узнать, является ли день недели, указанный цифровым значением(от 1 до 7), выходным днём.");
Console.Write("Пожалуйста, введите числовое значение, обозначающее день недели(от 1 до 7): ");
string str = Console.ReadLine() ?? "";
int number;
if(int.TryParse(str, out number))
{
    if(number > 0 && number < 8)
    {
        if(number > 5)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите значение от 1 до 7");
    }
}
else
{
    Console.WriteLine("Ошибка! Введите значение от 1 до 7");
}
