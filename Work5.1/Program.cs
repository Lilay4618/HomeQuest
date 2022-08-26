void RandomNumber(int[] randomArray)
{
    int pos = randomArray.Length;
    int count = 0;
    Console.Write("Числа в массиве: ");
    while(count < pos)
    {
        randomArray[count] = new Random().Next(100, 1000);
        Console.Write($"{randomArray[count]} ");
        count++;
    }
} 
int even(int[] randomArr)
{
    int num = randomArr.Length;
    int count = 0;
    int result = 0;
    while(count < num)
    {
        if(randomArr[count] % 2 == 0)
        {
            result = result + 1;
        }
        count++;
    }
    return result;
}
int[] newArray = new int[6];
RandomNumber(newArray);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {even(newArray)}");
