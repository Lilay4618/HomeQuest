double findX(double b1, double b2, double k1, double k2)
{
    double numX = (b2 - b1) / (k1 - k2); 
    return numX;
}

void findY(double numberX, double b1, double b2, double k1, double k2)
{
    double numY1 = k1 * numberX + b1;
    double numY2 = k2 * numberX + b2;
    if(numY1 == numY2)
    {
        Console.WriteLine($"Координаты точки пересечения: ({numberX};{numY1})");
    } 
    else
    {
        Console.WriteLine("Ошибка в программе");
    }
}


double numK1;
double numK2;
double numB1;
double numB2;

Console.WriteLine("Чтобы найти точку пересечения двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x*b2:");
Console.WriteLine("Введите значение k1: ");
string k1 = Console.ReadLine() ?? "";

if(double.TryParse(k1, out numK1))
{
    Console.WriteLine("Введите значение k2: ");
    string k2 = Console.ReadLine() ?? "";
    if(double.TryParse(k2, out numK2))
    {
        Console.WriteLine("Введите значение b1: ");
        string b1 = Console.ReadLine() ?? "";
        if(double.TryParse(b1, out numB1))
        {
            Console.WriteLine("Введите значение b2: ");
            string b2 = Console.ReadLine() ?? "";
            if(double.TryParse(b2, out numB2))
            {
                double numX = findX(numB1, numB2, numK1, numK2);
                findY(numX, numB1, numB2, numK1, numK2);
            }
            else Console.WriteLine("Ошибка! Заданные значения должны быть числовыми");
        }
        else Console.WriteLine("Ошибка! Заданные значения должны быть числовыми");
    }
    else Console.WriteLine("Ошибка! Заданные значения должны быть числовыми");
}
else Console.WriteLine("Ошибка! Заданные значения должны быть числовыми");
    


