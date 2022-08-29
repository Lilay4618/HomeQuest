void numberArr(int[] arr)
{
    int number = arr.Length;
    int index = 0; 
    Console.Write("Из чисел: ");
    while(index < number)
    {
        arr[index] = new Random().Next(-99999, 100000);
        Console.Write($"[{arr[index]}] ");
        index++;
    }
}

int notSubZero(int[] arr1)
{
    int index = arr1.Length;
    int count = 0;
    int result = 0;
    while(count < index)
    {
        if(arr1[count] > 0)
        {
            result++;
        }
        count++;
    }
    return result;
}

Console.Write("Введите количество чисел для проверки: ");
string quan = Console.ReadLine() ?? "";
int quanNum;

if(int.TryParse(quan, out quanNum));
else
{
    Console.WriteLine("Ошибка! Введите числовое значение!");
}

int[] array = new int[quanNum];
numberArr(array);
Console.WriteLine();
int final = notSubZero(array);
Console.WriteLine($"Количество положительных: {final}");