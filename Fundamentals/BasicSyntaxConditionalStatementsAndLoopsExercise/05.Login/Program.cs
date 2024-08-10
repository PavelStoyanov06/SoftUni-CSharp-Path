string user = Console.ReadLine();

string pass = string.Empty;

for (int i = user.Length - 1; i >= 0; i--)
{
    pass += user[i];
}

string input = Console.ReadLine();

int attempt = 1;

while (input != pass)
{
    Console.WriteLine("Incorrect password. Try again.");
    input = Console.ReadLine();
    attempt++;
    if(attempt >= 4)
    {
        Console.WriteLine("User {0} blocked!", user);
        Environment.Exit(0);
    }
}

Console.WriteLine("User {0} logged in.", user);