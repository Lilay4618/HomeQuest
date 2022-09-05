int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberM = ReadInt("Введите значение M: ");
int numberN = ReadInt("Введите значение N: ");

int funcAkkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0 && m > 0)
    {
        return funcAkkerman(m - 1,1);
    }
    else
    {
        return funcAkkerman(m - 1, funcAkkerman(m, n -1)); 
    }
}

int result = funcAkkerman(numberM, numberN);
Console.WriteLine(result);
