/// <summary>
/// Main program class for the console application
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point of the application
    /// </summary>
    /// <param name="args">Command line arguments</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Lukasz let's get started!!");
        
        // Test the SquareSum method
        int[] testNumbers = { 1, 2, 2 };
        int result = SquareSum(testNumbers);
        Console.WriteLine($"Square sum of [{string.Join(", ", testNumbers)}] = {result}");
    }

    /// <summary>
    /// Calculates the sum of squares of all numbers in the array
    /// </summary>
    /// <param name="numbers">Array of integers to process</param>
    /// <returns>Sum of squares of all numbers</returns>
    public static int SquareSum(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number * number;
        }
        return sum;
    }
}