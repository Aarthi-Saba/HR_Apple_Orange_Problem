using System;

namespace HR_Apple_Orange_Problem
{
    class Program
    {
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int apple_count = 0;

            foreach(var apple in apples)
            {
                if(apple < 0)
                {
                    continue;
                }
                if( apple+a >= s && apple+a <= t)
                {
                    apple_count += 1;
                }
            }
            Console.WriteLine(apple_count);
            int orange_count = 0;
            foreach(var orange in oranges)
            {
                if(orange > 0)
                {
                    continue;
                }
                if( orange+b >= s && orange+b <= t)
                {
                    orange_count += 1;
                }
            }
            Console.WriteLine(orange_count);

        }

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
