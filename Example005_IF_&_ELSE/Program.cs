Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "марина")
{
    Console.WriteLine("Ура это же Марина!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!");
}
