Console.WriteLine("Полиндром или не полиндром? Вот в чём вопрос...");
Console.Write("Пожалуйста, введите значение, которое хотите проверить ");
string text = Console.ReadLine() ?? "";
char[] text2 = text.ToCharArray();
Array.Reverse(text2);
string reverseText = new string(text2);
if(text == reverseText)
{
    Console.WriteLine("Заданное значение является полиндромом");
}
else
{
    Console.WriteLine("Заданное значение не является полиндромом");
}