Derivative derivative = (double x, double y) => x * y;
Parity parity = delegate (int x)
{
    bool r = (x % 2) == 0 ? true : false;
    return r;
};

Factorial factorial = delegate (int number)
{
    if (number == 1) 
    {
        return 1;
    }

    long result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
};

GetMaxNumberArray getMaxNumberArray = delegate (int[] array)
{
    int maxNumber = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > maxNumber) 
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
};



Console.Write(" Ввидите 2 числа для умножения: \n 1) ");
double.TryParse(Console.ReadLine(), out double x);
Console.Write(" 2) ");
double.TryParse(Console.ReadLine(), out double y);
double userDerivative = derivative(x, y);
Console.WriteLine( " Результат умножения: " + userDerivative);
Console.Write(" Введите число для сравнения четности: ");
int.TryParse(Console.ReadLine(), out int Uparity);
bool userParity = parity(Uparity);
Console.WriteLine($" Число: {Uparity} является: " + userDerivative);
Console.Write(" Введите число для факториала: ");
int.TryParse(Console.ReadLine(), out int Ufactorial);
long userFactorial = factorial(Ufactorial);
Console.WriteLine($" Фактоиалом числа {Ufactorial} является: {userFactorial}");
Random random = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    int r = random.Next(0,50000);
    array[i] = r;
}
Console.Write(" Вот массив из 10 случайных чисел: ");
foreach (int rundomNumber in array) 
{
    Console.Write($"{rundomNumber}, ");
}
var Max = getMaxNumberArray(array);
Console.WriteLine($" Вот максимальное число из массива {Max}");



delegate double Derivative(double x, double y);
delegate bool Parity(int x);
delegate long Factorial(int number);
delegate int GetMaxNumberArray(int[] array);