using Tyuiu.MedyanichevDI.Sprint3.Task7.V1.Lib;

namespace Tyuiu.MedyanichevDI.Sprint3.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("Написать программу которая выводит таблицу значения функций               *");
      
            // Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("                                                                          *");
            Console.WriteLine("***************************************************************************");

            //string k;

            //Console.WriteLine("Введите значение предложение X: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стартовое значение: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение: ");
            int z = Convert.ToInt32(Console.ReadLine());





            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMassFunction(y,z));

            Console.ReadKey();
        }
    }
}
