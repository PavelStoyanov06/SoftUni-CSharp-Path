const string PASSWORD = "s3cr3t!P@ssw0rd";

string input = Console.ReadLine();

if(input == PASSWORD)
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong password!");
}