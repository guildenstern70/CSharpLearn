/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

public class Collections
{
    public int NavigateList()
    {
        var sum = 0;
        foreach (var fish in this.ListOfStrings())
        {
            sum += fish.Length;
        }

        return sum;
    }

    public int NavigateDictionary()
    {
        var sum = 0;
        foreach (KeyValuePair<int, string> kvp in this.HashMap())
        {
            sum += kvp.Key;
            sum += kvp.Value.Length;
        }

        return sum;
    }

    public int NavigateArray()
    {
        var sum = 0;
        Span<int> numbers = this.Arrays();
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;

    }
    private int[] Arrays()
    {
        return new int[] {3, 14, 15, 92, 6};
    }

    private List<string> ListOfStrings()
    {
        return new List<string>
        {
            "chinook",
            "coho",
            "pink",
            "sockeye"
        };
    }

    private Dictionary<int, string> HashMap()
    {
        return new Dictionary<int, string>
        {
            {1, "notepad.exe"},
            {2, "paint.exe"},
            {3, "paint.exe"},
            {4, "wordpad.exe"}
        };
    }


}