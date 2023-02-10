Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "витя")
{
  Console.WriteLine("Ура, это же ВИТЯ!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}