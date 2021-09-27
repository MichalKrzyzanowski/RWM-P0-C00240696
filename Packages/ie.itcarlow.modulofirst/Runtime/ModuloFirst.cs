using UnityEngine;
public class ModuloFirst
{
    public static int[] moduloFirst(int[] xs)
    {
        int[] result = new int[xs.Length];
        int n = xs[0];

        for (int i = 0; i < xs.Length; ++i)
        {
            result[i] = xs[i] % n; 
        }

        return result;
    }
}