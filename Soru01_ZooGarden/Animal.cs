using System;

namespace Soru01_ZooGarden;


public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "Lion") { }

    public override void MakeSound()
    {
        Console.WriteLine("Kükreme");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "Elephant") { }

    public override void MakeSound()
    {
        Console.WriteLine("Boru");
    }
}

public class Giraffe : Animal
{
    public Giraffe(string name, int age) : base(name, age, "Giraffe") { }

    public override void MakeSound()
    {
        Console.WriteLine("Hışırtı");
    }
}

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Hayvan sesi");
    }

    public void Info()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Species: {Species}");
    }
}
