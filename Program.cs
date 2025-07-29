
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        string result = EvenOrOdd(1);

    }
    public static string EvenOrOdd(int number)
    {

        if(int.Abs(number) % 2 == 1)
        return "Odd";
        else
        return "Even";
    }
}