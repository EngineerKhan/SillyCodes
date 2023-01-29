using System;
using System.Collections.Generic;
using System.Linq;

public class RandomGenerator
{
    static int seed;
    public RandomGenerator(int s)
    {
        seed = s;
    }

    public int PRNG()
    {
        
        int x = 1069;
        int y = 2423;
        int z = ((x*seed+y)%y)+((x*seed+y)/y);

        seed++;

        return z;
    }
}

public class main 
{
     
    public static void Main()
    {
        RandomGenerator rng = new RandomGenerator(3);
        int[] values = Enumerable.Range(1, 100).ToArray();
        foreach(int n in values)
        {
            Console.WriteLine(rng.PRNG());
        }
        
    }
}