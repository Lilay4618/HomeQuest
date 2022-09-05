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
void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) -1 ; k++)
            {
                if (array [i, k] < array[i, k + 1])
                {
                    int result = array[i, k + 1];
                    array [i, k  + 1] = array [i, k];
                    array[i, k] = result;
                }
            }
        }
    }
}


int one = ReadInt("Зайдайте количество строк: ");
int two = ReadInt("Задайте количество столбцов: ");
int[,] arrayRan = new int[one, two];
RandomNumberArray(arrayRan);
PrintArray(arrayRan);
Sort(arrayRan);
PrintArray(arrayRan);

