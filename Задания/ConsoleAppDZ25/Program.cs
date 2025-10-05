internal class Numbers
{
    internal long CalculateFactorial(int number)
    {
        if (number == 1) return 1;

        return number * CalculateFactorial(number - 1);
    }

    internal string ConvertToBinary(int number)
    {
        long[] hashArray = new long[number];
        for (int i = 0; i < number; i++)
        {
            if (number >= 0)
            {
                hashArray[i] = number % 2;
                number = number / 2;
            }
            break;
        }
        string str = "";
        foreach (var num in hashArray) 
        {
            str += num.ToString();
        }
        return str;
    }

    internal long ConvertToHex(int number) 
    {
        return Convert.ToInt64(Convert.ToString(number, 16).ToUpper());
    }

    internal long CalculatePower(long footing, int degree)
    {
        if (degree == 0)
        {
            return 1;
        }

        if (degree % 2 == 0)
        {
            var p = CalculatePower(footing, degree / 2);
            return p * p;
        }
        else
        {
            return footing * CalculatePower(footing, degree - 1);
        }
    }
}
