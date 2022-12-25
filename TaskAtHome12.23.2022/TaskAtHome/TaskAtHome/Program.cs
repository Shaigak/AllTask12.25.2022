
using TaskAtHome;
using Service;
AccountService account = new AccountService();
//Console.WriteLine(account.Login("test@code.edu.az", "test12345", 3));


Console.WriteLine("Emaili daxil edin ");
string email=Console.ReadLine();
Console.WriteLine("Password daxil edin");
string password=Console.ReadLine();
Console.WriteLine("Roles daxil edin ");
int roles=int.Parse(Console.ReadLine());
Console.WriteLine(account.Login(email,password,roles));