﻿using System;
using System.Globalization;

public abstract class Shape
{
    public abstract double Area();
    public abstract override string ToString(); // เพิ่ม ToString()
}

public class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Radius cannot be negative.");
            }
            radius = value;
        }
    }

    public Circle(double radius) // เพิ่ม Constructor
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString() // Override ToString()
    {
        return $"Circle (Radius: {Radius})";
    }
}

public class Rectangle : Shape
{
    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width cannot be negative.");
            }
            width = value;
        }
    }

    public double Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height cannot be negative.");
            }
            height = value;
        }
    }

    public Rectangle(double width, double height) // เพิ่ม Constructor
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override string ToString() // Override ToString()
    {
        return $"Rectangle (Width: {Width}, Height: {Height})";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Shape shape1 = new Circle(5);
        Shape shape2 = new Rectangle(4, 6);

        CultureInfo culture = CultureInfo.InvariantCulture; // กำหนดรูปแบบการแสดงผลตัวเลข

        Console.WriteLine($"{shape1}: Area = {shape1.Area().ToString("0.00", culture)}"); // ใช้ ToString() และ CultureInfo
        Console.WriteLine($"{shape2}: Area = {shape2.Area().ToString("0.00", culture)}"); // ใช้ ToString() และ CultureInfo
    }
}