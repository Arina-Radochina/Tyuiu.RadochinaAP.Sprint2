using Tyuiu.RadochinaAP.Sprint2.Task4.V18.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: Тернарный оператор                                                                               *");
            Console.WriteLine("* Задание #4                                                                                             *");
            Console.WriteLine("* Вариант #18                                                                                            *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с исппользованием тернарного оператора,       *");
            Console.WriteLine("* где пользователь вводит значение переменных x, y с клавиатуры                                          *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Введите значение переменной Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);


            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();

        }

    }
}
