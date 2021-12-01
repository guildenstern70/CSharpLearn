/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

public class Loops
{
    public int NormalFor()
    {
        var sum = 0;
        for (var i = 0; i < 3; i++)
        {
            sum += 1;
        }
        
        return sum;
    }

    public int IterateList()
    {
        var sum = 0;
        var list = new List<int> {5, 23, 12, 34, 56, 99};
        foreach (var item in list)
        {
            sum += item;
        }

        return sum;
    }

    public int DoWhile()
    {
        var n = 0;
        do
        {
            n++;
        } while (n < 5);

        return n;
    }
    
    public int While()
    {
        var n = 0;
        while (n < 5)
        {
            n++;
        }

        return n;
    }
}
