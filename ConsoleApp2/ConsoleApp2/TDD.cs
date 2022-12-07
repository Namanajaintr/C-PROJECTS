using Xunit;

namespace ConsoleApp2
{
    public class TDD
    {
        [TestMethod]
        //    public void RooterValueRange()
        //    {
        //        // Create an instance to test.
        //        Rooter rooter = new Rooter();

        //        // Try a range of values.
        //        for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
        //        {
        //            RooterOneValue(rooter, expected);
        //        }
        //    }

        //    private void RooterOneValue(Rooter rooter, double expectedResult)
        //    {
        //        double input = expectedResult * expectedResult;
        //        double actualResult = rooter.SquareRoot(input);
        //        Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        //    }
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

}
