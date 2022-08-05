Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "илья")
{
    Console.WriteLine("Ура, это же ИЛЬЯ!");
}
else{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}