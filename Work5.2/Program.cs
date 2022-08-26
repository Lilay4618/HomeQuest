void RandomNumber(int[] randomArray)
{
    int pos = randomArray.Length;
    int count = 0;
    Console.Write("Числа в массиве: ");
    while(count < pos)
    {
        randomArray[count] = new Random().Next(-99999, 100000);
        Console.Write($"{randomArray[count]} ");
        count++;
    }
} 

int sumOdd(int[] oneDarray)
{
    int count = oneDarray.Length;
    int index = 1;
    int oddNumber = 0;
    while(index < count)
    {
        oddNumber = oddNumber + oneDarray[index];
        index = index + 2;
    }
    return oddNumber;
}

int[] array = new int[4];

RandomNumber(array);
sumOdd(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOdd(array)}");