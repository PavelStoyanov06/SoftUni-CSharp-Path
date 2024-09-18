const double PRICE_PER_SQ_METER = 7.61;

double sqMeters = double.Parse(Console.ReadLine());

double total = sqMeters * PRICE_PER_SQ_METER;

double discount = 18/100.0 * total;

total -= discount;

Console.WriteLine($"The final price is: {total} lv.");
Console.WriteLine($"The discount is: {discount} lv.");