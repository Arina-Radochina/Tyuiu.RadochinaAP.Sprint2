using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RadochinaAP.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 310 == y;
            res[1] = x + 1 != 1066;
            res[2] = x < y;
            res[3] = y + 10 > x;
            res[4] = x <= y;
            res[5] = y + 1 >= x;

            return res;

        }
    }
}