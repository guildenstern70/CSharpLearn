/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

internal class FirstNamePerson
{
    public string FirstName { get; }

    private FirstNamePerson(string firstName)
    {
        this.FirstName = firstName;
    }

    public static FirstNamePerson FromPerson(Person p)
    {
        return new FirstNamePerson(p.Name);
    }
    
}

public class Linq
{
    public int QueryExpressions()
    {
        var scores = new int[] { 97, 92, 81, 60 };

        // Query expression.
        var scoreQuery =
            from score in scores
            where score > 80
            select score;

        return scoreQuery.Sum();
    }

    public int Filter()
    {
        var dataset = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        return dataset.Where(x => x > 5).Sum();
    }

    public int Map()
    {
        var dataset = new Person[]
        {
            new Person("Maarten", "Koller"),
            new Person("Robin", "Holzker")
        };

        var mappedDataSet =
            dataset.Select(FirstNamePerson.FromPerson);

        return mappedDataSet.Sum(p => p.FirstName.Length);
    }
    
    public int SumAllElements()
    {
        var strings = new List<string>
        {
            "chinook",
            "coho",
            "pink",
            "sockeye"
        };
        
        return strings.Sum(fish => fish.Length);
    }
}