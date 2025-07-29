
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Lukasz let's get started!!");
        int[] test1 = { 1, 2, 3 };
        int sum = SquareSum(test1);
        Console.WriteLine(string.Join(" ", sum));

    }
    public static int SquareSum(int[] numbers)
    {
        int sum = 0; 
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }
        foreach (int number in numbers)
        {
            sum += number * number; 
         }

        return sum;
    }
}