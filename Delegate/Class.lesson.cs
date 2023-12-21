namespace Delegate
{
    public class Class
    {
        public static bool isTriangle(Tuple<int, int, int> myTuple)
        {
            if (Math.Pow(myTuple.Item1, 2) + Math.Pow(myTuple.Item2, 2) == Math.Pow(myTuple.Item3, 2))
            {
                return true;
            }
            return false;

        }
    }        
    public class MyEvent
    {
       /* Func<int[], int[]> func = delegate (int[] x)
        {
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * 2;
            }
            return y;
        };
        public void test()
        {

            foreach (int i in func([23, 3, 4, 5, 3, 3]))
            {
                Console.WriteLine(i);
            }
        }
*/


        public bool IsTortburchak(params int[] tomonlar)
        { 
            if (tomonlar.Length == 2 || tomonlar.Length == 4)
            {
                return true;
            }
            return false;
        }
        public bool IsTogriTortburchak(params int[] tomonlar)
        {
            if (tomonlar.Length == 2) return true;
            else if (tomonlar[0] == tomonlar[2] && tomonlar[1] == tomonlar[3]) return true;
            else return false;
        }

    }
}
