using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedyanichevDI.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
           
        {
            int len = stopValue - startValue + 1;
            double[] res= new double[len];
            double sum;
            int con = 0;
            for (int i = startValue; i<= stopValue; i++)
            {
                if (i == -1.2)
                {
                    sum = 0;
                    res[con] = sum;
                    break;
                }
                else
                {
                    sum = Math.Round(Math.Sin(i) / (i + 1.2f) + Math.Cos(i) * 7f * i - 2f,2);
                    res[con]=sum;
                    con++;
                }
            }
            return res;
        }
    }
}
