bool startProgram = true;


while (startProgram)
{
    Console.Write(" Введите значение 1: ");
    double.TryParse(Console.ReadLine(), out double userInputNumberOne);
    Console.Write("  Введите значение 2: ");
    double.TryParse(Console.ReadLine(), out double userInputNumberTwo);
}

Operation operation = Calc.Summ;
operation += Calc.Subtraction;
operation += Calc.Multiplication;
operation += Calc.Division;

internal static class Calc
{
    internal static void Summ(double NumberOne, double NumberTwo)
    {
        Console.WriteLine($" Сумма значений {NumberOne} и {NumberTwo} = {NumberOne + NumberTwo}");
    }

    internal static void Subtraction(double NumberOne, double NumberTwo)
    {
        Console.WriteLine($" Разность значений {NumberOne} и {NumberTwo} = {NumberOne - NumberTwo}");
    }

    internal static void Multiplication(double NumberOne, double NumberTwo)
    {
        Console.WriteLine($" Умножение значений {NumberOne} и {NumberTwo} = {NumberOne * NumberTwo}");
    }

    internal static void Division(double NumberOne, double NumberTwo)
    {
        Console.WriteLine($" Деление значений {NumberOne} и {NumberTwo} = {NumberOne / NumberTwo}");
    }

}

internal delegate void Operation(double one, double two);



//public class Calculator
//{
//    delegate void Operation(double a, double b);
//    public static void Sum(double a, double b)
//    {
//        Console.WriteLine((double)a + b);
//    }
//    public static void Substract(double a, double b)
//    {
//        Console.WriteLine(a - b);
//    }
//    public static void Multiply(double a, double b)
//    {
//        Console.WriteLine(a * b);
//    }
//    public static void Division(double a, double b)
//    {
//        Console.WriteLine(a / b);
//    }
//    public static void Main(string[] args)
//    {
//        Operation op = Sum;
//        op += Substract;
//        op += Multiply;
//        op += Division;
//        op(2, 8);

//    }
//}
