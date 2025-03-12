﻿using System;
using System.Collections.Generic;

public abstract class Shape
{
    public abstract void Draw();
    public abstract string GetShapeType(); // เพิ่ม method สำหรับคืนค่าชนิดของรูปทรง
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public override string GetShapeType()
    {
        return "Circle";
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }

    public override string GetShapeType()
    {
        return "Rectangle";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle());
        shapes.Add(new Rectangle());
        shapes.Add(new Circle());

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Drawing a {shape.GetShapeType()}");
            shape.Draw();
        }
    }
}