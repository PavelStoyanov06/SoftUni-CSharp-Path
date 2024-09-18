const double CHICKEN_MENU = 10.35;
const double FISH_MENU = 12.40;
const double VEGETARIAN_MENU = 8.15;
const double DELIVERY_COST = 2.50;

int numChicken = int.Parse(Console.ReadLine());
int numFish = int.Parse(Console.ReadLine());
int numVegeterian = int.Parse(Console.ReadLine());

double total = numChicken * CHICKEN_MENU + numFish * FISH_MENU + numVegeterian * VEGETARIAN_MENU;

total += (20 / 100.0) * total;

total += DELIVERY_COST;

Console.WriteLine(total);