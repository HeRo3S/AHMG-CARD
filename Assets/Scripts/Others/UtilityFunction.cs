using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public static class UtilityFunction
{

    private static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
    //Shuffle list
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (Byte.MaxValue / n)));
            int k = (box[0] % n);
            n--;
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    //Random number generator
    public static int randomNum(int min, int max)
    {
        if (min > max) throw new ArgumentOutOfRangeException(nameof(min));
        if (min == max) return min;
        {
            var data = new byte[4];
            provider.GetBytes(data);
            int generatedValue = Math.Abs(BitConverter.ToInt32(data, startIndex: 0));

            int diff = max - min;
            int mod = generatedValue % diff;
            int normalizedNumber = min + mod;
            return normalizedNumber;
        }
    }
}