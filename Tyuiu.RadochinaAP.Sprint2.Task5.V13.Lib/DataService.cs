using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RadochinaAP.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (m < 1 || m > 12)
            {
                return "Введено неверное значение";
            }

            if (n < 1)
            {
                return "Введено неверное значение";
            }

            // Определяем количество дней в месяце для ВИСОКОСНОГО года
            int daysInMonth;
            switch (m)
            {
                case 2: daysInMonth = 29; break; // Февраль в високосном году
                case 4: case 6: case 9: case 11: daysInMonth = 30; break;
                default: daysInMonth = 31; break;
            }

            // Проверка, что число не превышает количество дней в месяце
            if (n > daysInMonth)
            {
                return "Введено неверное значение";
            }

            // Вычисляем следующую дату
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

            // Форматируем с ведущими нулями: "09.09.2024"
            return $"{next_n:D2}.{next_m:D2}.{next_g}";
        }
    }
}