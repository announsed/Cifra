using System.Data;

Car carOne = new Car();
Car carTwo = new Car();
carOne.Left = 20;
carTwo.Left = 60;
Thread thread1 = new Thread(carOne.MovingForward);
Thread thread2 = new Thread(carTwo.MovingForward);
carOne.thread = thread1;
carTwo.thread = thread2;
thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();
Console.WriteLine(" Гонка потоков завершилась");


//while (true) 
//{
//    carOne.MovingForward();
//    carOne.GetInfoPosition(thread1);
//    carTwo.MovingForward();
//    carTwo.GetInfoPosition(thread2);
//    Thread.Sleep(1000);
//}


class Car 
{
    private readonly string _carObj = "*";
    private readonly Random _random = new Random();

    internal int Left { get; set; }
    internal Thread thread { get; set; }
    public void MovingForward() 
    {
        Console.CursorVisible = false;
        for (int i = 0; i < 100 ; i++)
        {
            Console.SetCursorPosition(Left, i);
            Console.WriteLine(_carObj);
            Thread.Sleep(_random.Next(198, 321));
        }
    }
    public void GetInfoPosition() 
    {
        Console.Write(Console.CursorLeft + " " + Console.CursorTop);
        Console.Write($"Идентификатор потока: {thread.ManagedThreadId} \n");
    }
}