/*
 * CSharpLearn Project
 * Copyright (c) Alessio Saltarin, 2021
 * This software is licensed under MIT License
 * See LICENSE
 */

namespace CSharpLearn;

internal abstract class Shape
{
    public virtual double Area()
    {
        return 0.0; 
    }

    public virtual double Perimeter()
    {
        return 0.0;
    }
}

internal class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        this.Side = side;
    }

    public override double Area()
    {
        return this.Side * this.Side;
    }
}

internal class Circle : Shape
{
    public double Radius { get; private set;  }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}

public class Polymorphism
{
    private double PolymorphicMethod(IEnumerable<Shape> shapes)
    {
        return shapes.Sum(shape => shape.Area());
    }

    public double PolymorphicTest()
    {
        var shapes = new List<Shape>
        {
            new Square(12.3),
            new Circle(8.5)
        };
        return this.PolymorphicMethod(shapes);
    }
}

