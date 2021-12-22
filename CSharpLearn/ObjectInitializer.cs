/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

public class ObjectInitializer
{
    public string CreateObject()
    {
        var person = new Person
        {
            Name = "Elena",
            Surname = "Zambrelli"
        };

        return person.ToString();
    }
}
 
