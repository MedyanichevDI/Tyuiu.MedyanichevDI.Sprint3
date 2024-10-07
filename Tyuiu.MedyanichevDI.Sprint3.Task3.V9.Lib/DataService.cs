﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MedyanichevDI.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    value = value.Remove(c, item);
                }
                
            }
            return value;
        }
    }
}
