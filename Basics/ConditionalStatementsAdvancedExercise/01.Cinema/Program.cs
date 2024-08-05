string type = Console.ReadLine();

double price = 0;
if (type == "Premiere")
    price = 12;
else if (type == "Normal")
    price = 7.5;
else if (type == "Discount")
    price = 5;

int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

double total = rows * cols * price;

Console.WriteLine($"{total:f2} leva");