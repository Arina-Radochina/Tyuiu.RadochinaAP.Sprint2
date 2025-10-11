using Tyuiu.RadochinaAP.Sprint2.Task6.V3.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: Получение результата из switch                                                                   *");
            Console.WriteLine("* Задание #6                                                                                             *");
            Console.WriteLine("* Вариант #3                                                                                             *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch вычисляет             *");
            Console.WriteLine("* требуемое значение и возвращает результат.                                                             *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Введите номер дня недели: ");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numDay < -1) || (numDay > 8))
            {
                res = "Введено неверное значение !";
            }
            else
            {
                res = "Этот день недели: " + ds.FindDayName(numDay);
            }
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

