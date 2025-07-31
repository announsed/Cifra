
Point OnePoint = new Point(8, 5);
Point TwoPoint = new Point(3, 8);
Console.WriteLine(Point.CounterPoint + " " + Point.LengthPoints(OnePoint, TwoPoint));



class Point
{
    public static int CounterPoint = 0;

    public readonly int X;
    public readonly int Y;
    public Point(int x, int y) 
    {
        X = x; 
        Y = y;
        CounterPoint++;
    }

    public static string LengthPoints(Point OnePoint, Point TwoPoint) 
    {
        int LenghtX = OnePoint.X - TwoPoint.X;
        int LenghtY = TwoPoint.Y - OnePoint.Y;

        return $"Расстояние между точками ({OnePoint} и {TwoPoint}): по X - {LenghtX}, по Y - {LenghtY}";
    }
}