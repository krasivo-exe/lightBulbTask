using System;

namespace lightBulbPuzzle
{
    class Program
    {
        static int count(int[] bulbs)
        {
            int count = 0;
            for(int i = 0; i<bulbs.Length;i++) if (shiner(subArray(bulbs, 0, i), bulbs[i])) count++;
            return count;
        }
        static bool shiner(int[] subBulbs, int val)
        {
            for(int i = 1; i<val;i++) if (!contains(subBulbs, i)) return false;
            return true;
        }
       static int[] subArray(int[] array,int iPos, int lPos)
        {
            int targetLength = (lPos - iPos) + 1;
            int[] subArr = new int[targetLength];
            for(int i = 0;i<targetLength;i++) subArr[i] = array[iPos + i];
            return subArr;
        }
        static bool contains(int[] array, int val)
        {
            for(int i = 0; i<array.Length;i++) if (array[i] == val) return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("A = [2,1,3,5,4]");
            int[] array = { 2, 1, 3, 5, 4 };
            int num = count(array);
            Console.WriteLine(num);
        }
    }
}
