﻿using System;
using System.Globalization;

public abstract class Shape
{
    public abstract double Area();
    public abstract void Draw();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
    }
}

public class ShapeProcessor
{
    public void DisplayShapeInfo(Shape shape)
    {
        CultureInfo culture = CultureInfo.InvariantCulture; // กำหนดรูปแบบการแสดงผลตัวเลข
        Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area().ToString("0.00", culture)}"); // ใช้ ToString() และ CultureInfo
        shape.Draw();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ShapeProcessor processor = new ShapeProcessor();
        Circle circle = new Circle(5);
        processor.DisplayShapeInfo(circle);
        Rectangle rectangle = new Rectangle(4, 6);
        processor.DisplayShapeInfo(rectangle);
    }
}