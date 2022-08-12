Console.WriteLine("Введи чё-нить ");
string slovo = Console.ReadLine() ?? "";
int chislo;

if(int.TryParse(slovo, out chislo))
{
    if(chislo % 2 == 0)
    {
        Console.WriteLine("Чётное");
    }
    else
    {
        Console.WriteLine("Нечётное");
    }
}
else
{
Console.WriteLine("Ну ладно. Не чё нить, а целое число! :)");
}