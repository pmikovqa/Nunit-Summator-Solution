namespace Summator
{
    public static class Summator
    {
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static double Average(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = sum / arr.Length;
            return average;
        }

        public static double PowerOfNumbers(double[] arr)
        {
            double result = Math.Pow(arr[0], arr[1]);

            return result;

        }

        public static double SqrRoot(double[] arr)
        {
            double result = Math.Sqrt(arr[0]);

            return result;

        }

        public static double BiggestNumber(double[] arr)
        {
            double maxNumber = Double.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber) {
                    maxNumber = arr[i];
                }
            }
            return maxNumber;
        }

        public static double SmallestNumber(double[] arr)
        {
            double minNumber = Double.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minNumber)
                {
                    minNumber = arr[i];
                }
            }
            return minNumber;
        }

        public static string ReversedString(string[] arr)
        {
            string statement = "inUtfoS";
            string reversedStatement = string.Empty;
            for (int i = arr.Length - 1; i >= 0; i--) 
            { 
                reversedStatement = reversedStatement + arr[i];
            }
            return reversedStatement;
        }


       

        
    }
}
