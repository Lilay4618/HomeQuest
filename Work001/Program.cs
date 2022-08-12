Console.WriteLine("Введи число №1 ");
string slovo1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите число №2 ");
string slovo2 = Console.ReadLine() ?? "";

double number1;
double number2;
double max;
double min;

if(double.TryParse(slovo1, out number1))
  {
    if(double.TryParse(slovo2, out number2))
    {
          if(number1 > number2)
                {
                max = number1;
                min = number2;
                }
            else
            {
                max = number2;
                min = number1;
            }
            Console.Write("max = ");
            Console.WriteLine(max);
            Console.Write("min = ");
            Console.WriteLine(min);
    }
    else
    {
        Console.WriteLine("Ошибка! Нужно число. Это такая циферка");
    }
  }
else 
{
    Console.WriteLine("Ошибка! Где то не число!");
}

    