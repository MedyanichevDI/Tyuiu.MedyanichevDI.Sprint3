using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MedyanichevDI.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)

        {
            double res=1;
            
            //valu =5
            //startv=1
            //stop = 6
           for (float i= startValue; i<=stopValue; i++)
            {
                res *= value/i;
                
            }
            res = Math.Pow(res, 3);
            return Math.Round(res+=.001,3,MidpointRounding.AwayFromZero );
        }
    }
}
