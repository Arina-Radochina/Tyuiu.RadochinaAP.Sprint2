using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RadochinaAP.Sprint2.Task2.V25.Lib
{
    public class DataService : ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 1) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                res = true;
            }
            else 
            {
                res = false;
            }
            return res;
        }
    }
}
