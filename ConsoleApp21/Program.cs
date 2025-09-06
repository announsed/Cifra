
 var i = await Calculate(1, 7);
Console.WriteLine(i);

static Task<long> Calculate(int oneNumber, int twoNumber)
{
    long hashPlus = 0;

    for (int i = oneNumber; i <= twoNumber; i++)
    {
        if ((i % 1 == 0 && i % i == 0) && i )
        {
            hashPlus += i;
        }
        else
        {
            continue;
        }
    }

    return Task.Run(() =>
    {
        return hashPlus;
    });
}
