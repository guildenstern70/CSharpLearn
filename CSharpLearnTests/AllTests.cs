/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using CSharpLearn;

namespace CSharpLearnTests;

public class AllTests
{
    [Fact]
    public void ClassTest()
    {
        var person = new Person
        {
            Name = "Alessio",
            Surname = "Saltarin"
        };
        person.Name.Should().Be("Alessio");
        person.ToString().Should().Be("Person > Alessio Saltarin");
    }

    [Fact]
    public void RecordTest()
    {
        var tvColor = new Television
        {
            Inches = "22",
            IsSmart = true
        };
        tvColor.IsSmart.Should().BeTrue();
        tvColor.ToString().Should().Be("Television { Inches = 22, IsSmart = True }");
    }

    [Fact]
    public void ListDictNavigation()
    {
        var collections = new Collections();
        var sum1 = collections.NavigateList();
        var sum2 = collections.NavigateDictionary();

        sum1.Should().Be(22);
        sum2.Should().Be(50);
    }


    [Fact]
    public void InheritanceTest()
    {
        var nicePerson = new NicePerson("Alessio", "Saltarin");
        nicePerson.ToString().Should().Be("Nice Person > Alessio Saltarin");
    }

    [Fact]
    public void Loops()
    {
        var loops = new Loops();

        loops.NormalFor().Should().Be(3);
        loops.IterateList().Should().Be(229);
        loops.While().Should().Be(5);
        loops.DoWhile().Should().Be(5);
    }

    [Fact]
    public void Linq()
    {
        var linq = new Linq();

        linq.Map().Should().Be(12);
        linq.Filter().Should().Be(40);
        linq.SumAllElements().Should().Be(22);
        linq.QueryExpressions().Should().Be(270);
    }
    

}