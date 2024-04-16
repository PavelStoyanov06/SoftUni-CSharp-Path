int yearlyTax = int.Parse(Console.ReadLine());

double shoes = yearlyTax - (40 / 100.0) * yearlyTax;
double clothes = shoes - (20 / 100.0) * shoes;
double ball = clothes * (1 / 4.0);
double accessories = ball * (1 / 5.0);

double total = yearlyTax + shoes + clothes + ball + accessories;

Console.WriteLine(total);