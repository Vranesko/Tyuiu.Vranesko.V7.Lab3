namespace SolveTabMathFuction.Lib
{
    public class TabMathFuction
    {
        public double[] GetMassFunction(int start, int end)
        {
            if (start > end)
                return new double[0];
            double[] results = new double[end - start + 1];
            int index = 0;

            for (int x = start; x <= end; x++)
            {
                double test = Math.Pow(x, 4) - Math.Pow(x, 5);
                if (x == 0)
                {
                    results[index] = double.NaN;
                }
                else
                {
                    results[index] = ((Math.PI + Math.Sin(x)) / Math.Pow(x, 3)) + Math.Sin(x) + Math.Abs(test);
                    results[index] = Math.Round(results[index], 2);
                }
                index++;
            }
            return results;
        }
    }
}
