using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0 )
                throw new ArgumentException();
            
            int n = source.Length;
            for (int i = 0; i < n /2; i++)
                if (source[i] != source[n - 1 - i])
                    return ("No");
           
            return ("Yes");

        }
    }
}
