string type = Console.ReadLine();

double area = default(double);

if (type == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = Math.Pow(side, 2);
}
else if(type == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    area = sideA * sideB;
}
else if(type == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * Math.Pow(radius, 2);
}
else if(type == "triangle")
{
    double side = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    area = side * height / 2;
}

Console.WriteLine($"{area:f3}");