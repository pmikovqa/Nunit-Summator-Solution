namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });

            if (result == 21)
            {
                Console.WriteLine("Test Pass");
            }
            else {
                Console.WriteLine("Test Fail");
            }
            double result2 = Summator.Average(new double[] { 6, 5 });   
            Console.WriteLine(result2);

            double result3 = Summator.PowerOfNumbers(new double[] { 2, 2, });
            Console.WriteLine(result3);

            double biggest = Summator.BiggestNumber(new double[] { 2, 5, 8, 10, 6, 4 });
            Console.WriteLine(biggest);
            double smallest = Summator.SmallestNumber(new double[] { 2, 5, 8, 10, 6, 4 });
            Console.WriteLine(smallest);

            string newStatement = Summator.ReversedString(new string[] { "i", "n", "U", "t", "f", "o", "S" });
            Console.WriteLine(newStatement);
        }   
    }
}