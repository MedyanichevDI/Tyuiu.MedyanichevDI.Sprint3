using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MedyanichevDI.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (float x = startValue; x <= stopValue; x++)
            {
                res = (Math.Sin(x) - x) / x;
                if (x == 0)
                {
                    continue;
                }
            }
            return res;
        }
    }
}
