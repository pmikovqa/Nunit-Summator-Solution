using NUnit.Framework;

namespace Summator.tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            int result = Summator.Sum(new int[] { 5,});

            Assert.That(result == 5);
        }

        [Test]
        public void Test_Average()
        {
            double result = Summator.Average(new double[] { 6, 5 });
            
            Assert.That(result == 5.5);
        }

        [Test]
        public void Test_Sum_MultiplePositiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 7, 15, 89, 58, 98, 78, 2, 56 });

            int expected = 408;

            Assert.That(result == expected);
        }

        [Test]
        public void Test_NumbersPowered()
        {
            double result3 = Summator.PowerOfNumbers(new double[] { 5, 2, });

            double expected = 25;

            Assert.That(result3 == expected);
        }

        [Test]
        public void Test_SquareRoot()
        {
            double result = Summator.SqrRoot(new double[] { 16 });

            double expected = 4;

            Assert.That(result == expected);
        }

        [Test]
        public void Test_BiggestNumber()
        {
            double biggest = Summator.BiggestNumber(new double[] { 2, 5, 8, 10, 6, 4 });

            double expected = 10;

            Assert.That(biggest == expected);
        }

        [Test]
        public void Test_SmallestNumber()
        {
            double smallest = Summator.SmallestNumber(new double[] { 2, 5, 8, 10, 6, 4 });

            double expected = 2;

            Assert.That(smallest == expected);
        }

        [Test]
        public void Test_ReversedString()
        {
            string newStatement = Summator.ReversedString(new string[] { "i", "n", "U", "t", "f", "o", "S" });

            string expected = "SoftUni";

            Assert.That(newStatement.Equals(expected));
        }
    }
    }