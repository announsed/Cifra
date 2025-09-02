Thread thread1 = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Counter.Increase();
    } 
});
Thread thread2 = new Thread(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Counter.Decrease();
    }
});
thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();
Console.WriteLine(" Всё завершилась");



internal static class Counter
{
    public static object lockObject = new object();
    public static int count = 0;
    public static void Increase()
    {
        lock (lockObject)
        {
            count++;
            Console.WriteLine($"Значение: {count} увеличено на 1");
        }
    }
    public static void Decrease()
    {
        lock (lockObject)
        {
            count--;
            Console.WriteLine($"Значение: {count} уменьшено на 1");
        }
    }

}