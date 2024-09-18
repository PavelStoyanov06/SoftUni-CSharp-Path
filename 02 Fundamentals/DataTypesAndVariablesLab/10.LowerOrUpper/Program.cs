char character = char.Parse(Console.ReadLine());

if(character.ToString().ToLower() == character.ToString())
{
    Console.WriteLine("lower-case");
}
else
{
    Console.WriteLine("upper-case");
}