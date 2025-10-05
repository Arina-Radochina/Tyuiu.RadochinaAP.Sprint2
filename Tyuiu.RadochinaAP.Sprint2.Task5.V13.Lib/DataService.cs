using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RadochinaAP.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (m < 1 || m > 12 || n < 1)
                throw new ArgumentException("Некорректная дата!");

            int daysInMonth = GetDaysInMonth(m);
            if (n > daysInMonth)
                throw new ArgumentException("Некорректная дата!");

            int next_g = g, next_m = m, next_n = n + 1;

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

            return $"{next_g}-{next_m}-{next_n}";
        }

        private int GetDaysInMonth(int month)
        {
            switch (month)
            {
                case 2: return 29;
                case 4: case 6: case 9: case 11: return 30;
                default: return 31;
            }
        }
    }
}
          
