int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = ReadInt("Введите значение M: ");
int numberN = ReadInt("Введите значение N: ");

if(numberM < numberN)
{
    while(numberM <= numberN)
    {
        Console.WriteLine($"{numberM} ");
        numberM++;
    }
}
else
{
    while(numberM >= numberN)
    {
        Console.WriteLine($"{numberM} ");
        numberM = numberM - 1;
    }
}