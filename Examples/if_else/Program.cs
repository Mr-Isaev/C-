Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Маша"){
	Console.WriteLine("Привет, Мой господин");
}
else{
	Console.Write("Привет, ");
	Console.Write(username);
}