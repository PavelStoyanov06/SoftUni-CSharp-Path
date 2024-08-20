int max = int.Parse(Console.ReadLine());
int total = 0;
bool isSpecial = false;
for (int i = 1; i <= max; i++)
{
    int temp = i;
    while (temp > 0)
    {
        total += temp % 10;
        temp = temp / 10;
    }
    isSpecial = (total == 5) || (total == 7) || (total == 11);
    Console.WriteLine("{0} -> {1}", i, isSpecial);
    total = 0;
}
