int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char op = char.Parse(Console.ReadLine());

switch (op)
{
	case '+':
        Console.WriteLine($"{n1} + {n2} = {n1 + n2} - " + ((n1 + n2) % 2 == 0 ? "even" : "odd"));
        break;
    case '-':
        Console.WriteLine($"{n1} - {n2} = {n1 - n2} - " + ((n1 - n2) % 2 == 0 ? "even" : "odd"));
        break;
    case '*':
        Console.WriteLine($"{n1} * {n2} = {n1 * n2} - " + ((n1 * n2) % 2 == 0 ? "even" : "odd"));
        break;
    case '/':
        if(n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
            break;
        }
        Console.WriteLine($"{n1} / {n2} = {Convert.ToDouble(n1) / n2:f2}");
        break;
    case '%':
        if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
            break;
        }
        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
        break;
    default:
		break;
}