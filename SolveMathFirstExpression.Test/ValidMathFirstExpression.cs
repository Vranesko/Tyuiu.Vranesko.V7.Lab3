using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public sealed class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestMethod1()
        {
            var z1 = new MathFirstExpression();
            int x = 1;
            int y = 1;
            int a = 1;
            double zf1 = z1.Zfunc1(x, y, a);
            Assert.AreEqual(1, zf1);
        }
    }
}
