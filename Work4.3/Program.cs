Console.WriteLine("Хотите увидеть рандомный массив из 8 элементов?");
Console.WriteLine("Да/Нет: ");
string str1 = Console.ReadLine() ?? "";
if(str1.ToLower() == "да")
{
    int[] arr = new int[8];
    int x = 0;
    while(x < 8)
    {
        arr[x] = new Random().Next(1, 10);
        x++;
    }
    var str = string.Join(", ", arr);
    Console.WriteLine($"Массив: [{str}]");
}
if(str1.ToLower() == "нет")
{
    Console.WriteLine("Ну нет, так нет");
}
