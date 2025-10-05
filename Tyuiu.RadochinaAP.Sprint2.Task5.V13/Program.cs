using Tyuiu.RadochinaAP.Sprint2.Task5.V13.Lib;

namespace Tyuiu.RadochinaAP.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: Оператор switch                                                                                  *");
            Console.WriteLine("* Задание #5                                                                                             *");
            Console.WriteLine("* Вариант #13                                                                                            *");
            Console.WriteLine("* Выполнила: Радочина Арина Павловна | ПИНб-25-1                                                         *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет                                       *");
            Console.WriteLine("* требуемое значение и возвращает результат.                                                             *");
            Console.WriteLine("*                                                                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");

            Console.WriteLine("Введите значение года (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение дня (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((m < 1) || (m > 12) || (n < 1))
            {
                res = "Введено неверное значение";
            }
            else
            {
                int daysInMonth;
                switch (m)
                {
                    case 2: daysInMonth = 29; break; 
                    case 4: case 6: case 9: case 11: daysInMonth = 30; break;
                    default: daysInMonth = 31; break;
                }

                if (n > daysInMonth)
                {
                    res = "Введено неверное значение";
                } 
                else
                {
                    int next_g = g;
                    int next_m = m;
                    int next_n = n + 1;

                    if (next_n > daysInMonth)
                    {
                        next_n = 1;
                        next_m++;

                        if (next_m > 12)
                        {
                            next_m = 1;
                            next_g++;
                        }
                    }
                    res = $"{next_n:D2}.{next_m:D2}.{next_g}";
                }
            }
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");


            Console.WriteLine($"Дата следующего дня: {res}");
            Console.ReadKey();
        }
    }

}
