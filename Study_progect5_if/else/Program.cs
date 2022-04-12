// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Адель")
{
    Console.WriteLine("Привет, солнышко");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}