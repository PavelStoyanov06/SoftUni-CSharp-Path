string input = Console.ReadLine();

switch (input)
{
    case "USA":
    case "England":
        Console.WriteLine("English");
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        Console.WriteLine("Spanish");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}