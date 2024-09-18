int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int temp = i;
    int sumDigits = 0;

    while (temp != 0)
    {
        sumDigits += temp % 10;
        temp /= 10;
    }

    Console.WriteLine($"{i} -> " + ((sumDigits == 5 || sumDigits == 7 || sumDigits == 11) ? "True" : "False"));
}