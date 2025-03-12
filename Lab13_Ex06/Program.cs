﻿using System;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Animal Constructor: {Name}");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
        Console.WriteLine($"Dog Constructor: {Name}, {Breed}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", "Golden Retriever");

        // เพิ่มการแสดงผลข้อมูลของ Dog Object
        Console.WriteLine($"Dog Name: {dog.Name}");
        Console.WriteLine($"Dog Breed: {dog.Breed}");
    }
}