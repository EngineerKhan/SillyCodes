using System;
using System.Collections.Generic;
using System.Linq;

public class main 
{
    public static int SimplePRNG(int seed)
    {
        int x = 1069;
        int y = 2423;
        int z = ((x*seed+y)%y)+((x*seed+y)/y); //Because I can!
        return z;
    }
    
    public static void Main()
    {
        int[] values = Enumerable.Range(1, 100).ToArray();
        foreach(int n in values)
        {
            Console.WriteLine(SimplePRNG(n));
        }
        
    }
}