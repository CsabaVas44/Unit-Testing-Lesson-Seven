namespace MathFunction
{
    public class MathFunctions
    {
        public MathFunctions()
        {

        }
        public int Area (int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return x * y;
            }
            else return 0;
        }

        public double CircleArea(int radius)
        {
            if (radius > 0)
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            else
            {
                return 0;
            }
        }

        public T Max<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        
        public int AdditionList(List<int> list)
        {
            int all = 0;
            foreach(var item in list)
            {
                all += item;
            }
            return all;
        }
    }
}
