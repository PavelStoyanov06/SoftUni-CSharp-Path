int n = int.Parse(Console.ReadLine());

for (int i = 1111; i <= 9999; i++)
{
    int temp = i;
    bool isSpecial = true;
    while (temp > 0)
    {
        int dig = temp % 10;
        if(dig == 0 || n % dig != 0)
        {
            isSpecial = false;
            break;
        }
        temp /= 10;
    }
    if (isSpecial)
    {
        Console.Write(i + " ");
    }
}