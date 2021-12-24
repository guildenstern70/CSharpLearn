/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using CSharpLearn;
using Nullable = CSharpLearn.Nullable;

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
    public void ListDictNavigationTest()
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
    public void LoopsTest()
    {
        var loops = new Loops();

        loops.NormalFor().Should().Be(3);
        loops.IterateList().Should().Be(229);
        loops.While().Should().Be(5);
        loops.DoWhile().Should().Be(5);
    }

    [Fact]
    public void LinqTest()
    {
        var linq = new Linq();

        linq.Map().Should().Be(12);
        linq.Filter().Should().Be(40);
        linq.SumAllElements().Should().Be(22);
        linq.QueryExpressions().Should().Be(270);
    }

    [Fact]
    public void NullableTest()
    {
        var nullable = new Nullable();

        nullable.NullString().Should().BeNegative();
        nullable.IfIsNull().Should().Be("NeedToCheckforNull");
    }

    [Fact]
    public void IndexerTest()
    {
        var index = new Indexer();
        index[1].Should().Be("blue");
        index[2] = "green";
        index[2].Should().Be("green");
    }

    [Fact]
    public void PolymorphismTest()
    {
        var polymorph = new Polymorphism();
        double result = Math.Ceiling(polymorph.PolymorphicTest());
        result.Should().Be(379);
    }

    [Fact]
    public void ObjectInitializerTest()
    {
        var initializer = new ObjectInitializer();
        string createdPerson = initializer.CreateObject();
        createdPerson.Should().Be("Person > Elena Zambrelli");
    }

    [Fact]
    public void RecordStructTest()
    {
        var recording = new Recording() {Artist = "Beatles", Title = "She Loves You"};
        recording.Artist.Should().Be("Beatles");
        recording.Id.ToString().Length.Should().BePositive();
    }

    [Fact]
    public void ExpressionBodyTest()
    {
        var multiplier = new Multiplier(6, 7);
        multiplier.A.Should().Be(6);
        multiplier.B.Should().Be(7);
        multiplier.Result.Should().Be(42);
        multiplier.ToString().Should().Be("6 * 7 = 42");
    }
}