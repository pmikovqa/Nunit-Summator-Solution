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
    }
    }