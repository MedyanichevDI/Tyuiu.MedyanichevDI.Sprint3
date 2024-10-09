using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedyanichevDI.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
           
        {
            double[] res = new double[10];
            double sum;
            for (int i = startValue; i<= stopValue; i++)
            {
                if (i == -1.2)
                {
                    res.Append(0);
                    break;
                }
                else
                {
                    sum = Math.Round(Math.Sin(i) / (i + 1.2f) + Math.Cos(i) * 7f * i - 2f,2);
                    res.Append(sum);
                }
            }
            return res;
        }
    }
}
