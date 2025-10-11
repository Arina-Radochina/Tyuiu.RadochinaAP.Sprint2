using Tyuiu.RadochinaAP.Sprint2.Task7.V15.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: Добавление к итоговому проектов по спринту                                                       *");
            Console.WriteLine("* Задание #7                                                                                             *");
            Console.WriteLine("* Вариант #15                                                                                            *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения)                  *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.                           *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Введите значение переменной Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области");
            }

            Console.ReadKey();
        }

    }
}
