Snowflake snowflake1 = new Snowflake();
Thread thread = new Thread(snowflake1.Launch);
thread.Start();

class Snowflake
{
    private char _snow = '*';
    public int Random;
    private void AreaRandom() 
    {
        Random random = new Random();
        this.Random =  random.Next(0, Console.WindowWidth);
    }
    private void Movement(int top)
    {
        Console.Clear();
        Console.SetCursorPosition(Random, top);
        Console.Write(_snow);
        Thread.Sleep(360);
    }

    public void Launch() 
    {
        Console.CursorVisible = false;
        AreaRandom();
        for (int i = 0; i < Console.WindowHeight; i++)
        {
            Movement(i);
        }
    }
}