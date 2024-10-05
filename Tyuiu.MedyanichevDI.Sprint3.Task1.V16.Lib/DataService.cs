using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MedyanichevDI.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        double res = 0;
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            while (startValue<= stopValue)
            {
                res += Math.Pow(value, 2) * Math.Sin(startValue) + 1;
                startValue++;
            }
            return Math.Round(res,3);
        }
    }
}
