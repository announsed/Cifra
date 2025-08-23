SSH.Point OnePoint = new SSH.Point(8, 5);
SSH.Point TwoPoint = new SSH.Point(3, 8);
    Console.WriteLine(SSH.Point.CounterPoint + " " + SSH.Point.LengthPoints(OnePoint, TwoPoint));



namespace SSH
{



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



    // Практика на пространства имен
    public class SSH
    {
        public static void SSHVoid(string information)
        {
            Console.WriteLine(information);
        }
    }
}