int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void RandomNumberArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int one = ReadInt("Введите количество строк: ");
int two = ReadInt("Введите количество столбцов: ");
int[,] array1 = new int[one, two];
int[,] array2 = new int[one, two];
int[,] arrayFinal = new int[one, two];

RandomNumberArray(array1);
PrintArray(array1);
Console.WriteLine();

RandomNumberArray(array2);
PrintArray(array2);
Console.WriteLine();

if (array1.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        arrayFinal[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            arrayFinal[i, j] += array1[i, k] * array2[k, j];
        }
    }
}

PrintArray(arrayFinal);



