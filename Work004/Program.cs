Console.WriteLine("Введи целое число ");
string slovo = Console.ReadLine() ?? "";
int number;

if(int.TryParse(slovo, out number))
{
    if(number % 2 == 0)
    {
        number = number * 1;
    }

    else
    {
        number = number - 1;
    }
        while(number > 0)
        {
            Console.WriteLine(number); 
            number = number - 2;
        }
}
else
{
Console.WriteLine("ЦЕЛОЕ ЧИСЛО!");    
}