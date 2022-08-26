void RandomNumber(double[] randomArray)
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

double min(double[] minArray)
{
    int index = minArray.Length;
    int count = 0;
    double minNumber = minArray[count];
    while(count < index)
    {
        if(minNumber > minArray[count])
        {
            minNumber = minArray[count];
        }
        count++;
    }
    return minNumber;
}

double max(double[] maxArray)
{
    int index = maxArray.Length;
    int count = 0;
    double maxNumber = maxArray[count];
    while(count < index)
    {
        if(maxNumber < maxArray[count])
        {
            maxNumber = maxArray[count];
        }
        count++;
    }
    return maxNumber;
}

double[] testArray = new double[6];

RandomNumber(testArray);
min(testArray);
max(testArray);

Console.WriteLine();
double result = max(testArray) - min(testArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result}");
