namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double Zfunc2(double x, double y, double a)
        {
            return 3 * x + (2 - 3 * a) / (8 * x + 3 * a) + 2 + ((a / (y + 1)) + (2 * a / y)) * ((3 - a) / (x + y));
        }
    }
}
