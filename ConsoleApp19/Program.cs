using System;
using System.Reflection;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        // Создаем экземпляры RunLine
        RunLine runLine1 = new RunLine();
        RunLine runLine2 = new RunLine();

        // Создаем задачи и передаем им методы экземпляров
        Task oneTask = Task.Run(() =>
        {
            runLine1.Run();
        });

        Task task2 = Task.Run(() =>
        {
            runLine2.RunLiner();
        });

        // Ждем завершения задач
        Task.WaitAll(oneTask, task2);
    }
}

internal class RunLine
{
    public Task Task { get; set; }

    internal void Run()
    {
        Console.WriteLine($"{GetType().FullName} {Task?.Id} Это в методе: {MethodBase.GetCurrentMethod().Name}");
    }

    internal void RunLiner()
    {
        Console.WriteLine($"{GetType().FullName} {Task?.Id} Это в методе: {MethodBase.GetCurrentMethod().Name}");
    }
}