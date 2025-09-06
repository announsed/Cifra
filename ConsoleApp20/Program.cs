
Task taskRundom1 = Task.Run(() =>
{
    Random random = new Random();
    Console.WriteLine(random.Next(0, 256) + "    Вот это случайное число в диапазоне 0 - 255");
});

Task taskRundom2 = Task.Run(() =>
{
    Random random = new Random();
    Console.WriteLine(random.Next(0, 27) + "    Вот это случайное число в диапазоне 0 - 27");
});
Task.WaitAll(taskRundom1, taskRundom2);