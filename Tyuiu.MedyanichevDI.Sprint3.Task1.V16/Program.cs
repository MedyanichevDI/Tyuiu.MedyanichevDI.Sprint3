using Tyuiu.MedyanichevDI.Sprint3.Task1.V16.Lib;

namespace Tyuiu.MedyanichevDI.Sprint3.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("Написать программу используя цикл for, которая вычисляет произведение     *");
            Console.WriteLine("*ряда по формуле, при x = 0,7                                             *");
            // Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");

            //string k;

            Console.WriteLine("Введите значение предложение X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стартовое значение: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            int z = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(x, y, z));

            Console.ReadKey();
        }
    }
}
