using Tyuiu.RadochinaAP.Sprint2.Task3.V1.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: Вложенные операторы if-else                                                                      *");
            Console.WriteLine("* Задание #3                                                                                             *");
            Console.WriteLine("* Вариант #1                                                                                             *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием                    *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры. *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey(); 


        }
    }
}
