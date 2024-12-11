using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public sealed class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestMethod1()
        {
            var z2 = new MathSecondExpression();
            int x = 1;
            int y = 1;
            int a = 1;
            double zf2 = z2.Zfunc2(x, y, a);
            Assert.AreEqual(7.41, zf2, 0.01);
        }
    }
}
