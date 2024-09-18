const double DOG_FOOD_COST = 2.5;
const double CAT_FOOD_COST = 4;

int numDogPacks = int.Parse(Console.ReadLine());
int numCatPacks = int.Parse(Console.ReadLine());

double total = numDogPacks * DOG_FOOD_COST + numCatPacks * CAT_FOOD_COST;

Console.WriteLine($"{total} lv.");