﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MedyanichevDI.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)

        {
            double res=0;
            

           for (int i= startValue; i< stopValue; i++)
            {
                res *= Math.Pow(value / i, 3);
            }
            return res;
        }
    }
}
