int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = ReadInt("Введите значение M: ");
int numberN = ReadInt("Введите значение N: ");
int result = 0;

if(numberM < numberN)
{
    while(numberM <= numberN)
    {
        result = result + numberM;
        numberM++;
    }
}
else
{
    while(numberM >= numberN)
    {
        result = result + numberM;
        numberM = numberM - 1;
    }
}
Console.WriteLine(result);
