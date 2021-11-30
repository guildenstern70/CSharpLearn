/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */


using FluentAssertions;
using Xunit;

namespace CSharpLearnTests;

public class ClassTest
{
    [Fact]
    public void CreationTest()
    {
        var person = new Person
        {
            Name = "Alessio",
            Surname = "Saltarin"
        };
        person.Name.Should().Be("Alessio");
        person.ToString().Should().Be("Person > Alessio Saltarin");
    }
}