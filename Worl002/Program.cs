Console.WriteLine("Введи число №1 ");
string slovo1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите число №2 ");
string slovo2 = Console.ReadLine() ?? "";
Console.WriteLine("Введите число №3 ");
string slovo3 = Console.ReadLine() ?? "";

double number1;
double number2;
double number3;

if(double.TryParse(slovo1, out number1))
{
    if(double.TryParse(slovo2, out number2))
    {
        if(double.TryParse(slovo3, out number3))
        {
        double max = number1;
            if(number2 > max)
            {
                max = number2;
            }
                if(number3 > max)
                {
                    max = number3;
                }
                    Console.Write("МаксЫмум = ");
                    Console.WriteLine(max);        

        }
        else
        {
            Console.WriteLine("Ошибка ввода! ");
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода! ");
    }
}
else
{
    Console.WriteLine("Ошибка ввода! ");
}