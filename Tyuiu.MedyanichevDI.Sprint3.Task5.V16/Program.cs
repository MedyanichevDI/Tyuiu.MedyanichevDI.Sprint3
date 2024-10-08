using Tyuiu.MedyanichevDI.Sprint3.Task5.V16.Lib;

namespace Tyuiu.MedyanichevDI.Sprint3.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #16                                                              *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("Написать программу используя цикл do...while,                              *");
            Console.WriteLine("*которая вычисляет произведение ряда по формуле                           *");
            // Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");

            //string k;

             Console.WriteLine("Введите значение предложение X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стартовое значение1: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение1: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стартовое значение2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение2: ");
            int z2 = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x,y, y2,z,z2));

            Console.ReadKey();
        }
    }
}
