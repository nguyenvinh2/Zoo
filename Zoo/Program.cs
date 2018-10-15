using System;

namespace Zoo
{
  abstract class Animal
  {
    abstract public string name { get; set; }
    abstract public int age { get; set; }
    abstract public string coating { get; }
    abstract public int ExpectedLifeSpan();
    abstract public void MakeSound();

  }

  abstract class Mammal: Animal
  {
    public virtual void Action()
    {
      Console.WriteLine($"{name} wants to love you");
    }
    public override string coating
    {
      get { return "Fur"; }
    }
  }

  abstract class Fish: Animal
  {
    public override string coating
    {
      get { return "Scales"; }
    }
  }

  abstract class Aves: Animal
  {
    public override string coating
    {
      get { return "Feathers"; }
    }
  }

  class Dog : Mammal
  {
    string _name;
    int _age;
    Random lifeSpan = new Random();
    public override string name
    {
      get { return _name; }
      set { _name = value; }
    }

    public override int age
    {
      get { return _age; }
      set { _age = value; }
    }
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(10, 13);
    }

    public override void MakeSound()
    {
      Console.WriteLine($"{name} goes woof");
    }
  }

  class Cat: Mammal
  {
    string _name;
    int _age;
    Random lifeSpan = new Random();
    public override string name
    {
      get { return _name; }
      set { _name = value; }
    }

    public override int age
    {
      get { return _age; }
      set { _age = value; }
    }
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(2, 16);
    }

    public override void MakeSound()
    {
      Console.WriteLine($"{name} goes meoow");
    }

    public override void Action()
    {
      Console.WriteLine($"{name} wants to kill you");
    }
  }

  class Puffer: Fish
  {
    string _name;
    int _age;
    Random lifeSpan = new Random();
    public override string name
    {
      get { return _name; }
      set { _name = value; }
    }

    public override int age
    {
      get { return _age; }
      set { _age = value; }
    }
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(8,25);
    }
    public override void MakeSound()
    {
      Console.WriteLine($"{name} goes beleeep");
    }
  }

  class Pirahna: Fish
  {
    string _name;
    int _age;
    Random lifeSpan = new Random();
    public override string name
    {
      get { return _name; }
      set { _name = value; }
    }

    public override int age
    {
      get { return _age; }
      set { _age = value; }
    }
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(4,25);
    }
    public override void MakeSound()
    {
      Console.WriteLine($"{name} goes bloooop");
    }
  }

  class CrownEagle: Aves
  {
    string _name;
    int _age;
    Random lifeSpan = new Random();
    public override string name
    {
      get { return _name; }
      set { _name = value; }
    }

    public override int age
    {
      get { return _age; }
      set { _age = value; }
    }
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(14,36);
    }
    public override void MakeSound()
    {
      Console.WriteLine($"{name} goes Aaaaahhhh");
    }
  }

  class Sparrow: Aves
  {
    string _name;
    int _age;
    Random lifeSpan = new Random();

    public override string name
    {
      get { return _name; }
      set { _name = value; }
    }
  
    public override int age
    {
      get { return _age; }
      set { _age = value; }
    }

    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(1, 5);
    }
    public override void MakeSound()
    {
      Console.WriteLine($"{name} goes eeeechhh");  
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Dog Spotty = new Dog();
      Spotty.name = "alios";
      Spotty.age = 10;
      Console.WriteLine(Spotty.age);
      Console.WriteLine(Spotty.ExpectedLifeSpan());
      Console.WriteLine(Spotty.coating);
      Spotty.MakeSound();
      Spotty.Action();
      Cat Spitty = new Cat();
      Console.WriteLine(Spitty.ExpectedLifeSpan());
      Spitty.name = "alios";
      Spitty.age = 10;
      Console.WriteLine(Spitty.age);
      Console.WriteLine(Spitty.coating);
      Spitty.Action();
      Console.ReadKey();
    }
  }
}
