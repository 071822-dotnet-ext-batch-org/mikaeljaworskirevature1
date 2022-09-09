using System;
using System.Collections.Generic;

public class Test
{
    public static int addingNumbers(string S)
    {
        //this is default OUTPUT. You can change it.
        int x = S.Length;
        int result = -1;
        
        //write your Logic here:
        for (int i = 0; i < x - 1; i++)
            for (int j = i + 1; j < x; j++)
                if (S[i] == S[j])
                    result = Math.Max(result, Math.Abs(i - j - 1));

        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        string S = Console.ReadLine();
       
        // OUTPUT [uncomment & modify if required]
        Console.WriteLine(addingNumbers(S));
    }
}