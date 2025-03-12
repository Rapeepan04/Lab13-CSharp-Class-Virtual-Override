﻿using System;

public class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class AnimalSound
{
    public void PlaySound(Animal animal)
    {
        animal.makeSound();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AnimalSound sound = new AnimalSound();
        Animal dog = new Dog();
        Animal cat = new Cat();

        sound.PlaySound(dog);
        sound.PlaySound(cat);
    }
}