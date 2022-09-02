Console.WriteLine("Введите количество строк массива");
string str = Console.ReadLine() ?? "";
Console.WriteLine("Введите количество столбцов массива");
string sto = Console.ReadLine() ?? "";
int numStr;
int numSto;
int.TryParse(str, out numStr);
int.TryParse(sto, out numSto);

int[,] a = new int[numStr, numSto];
 
Random random = new Random();
for (int i = 0; i < numStr; i++)
{
    for (int j = 0; j < numSto; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,4}", a[i, j]);
    }
    Console.WriteLine();
}

