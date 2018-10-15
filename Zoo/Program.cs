using System;

namespace Zoo
{
  abstract class Animal
  {
    abstract public string CanItSwim();
    abstract public int LifeSpan();
  }

  abstract class Mammal: Animal
  {
    public override string CanItSwim()
    {
      return "Possibly";
    }
  }

  abstract class Fish: Animal
  {
    public override string CanItSwim()
    {
      return "Yes";
    }
  }

  abstract class Aves: Animal
  {
    public override string CanItSwim()
    {
      return "Yes";
    }
  }

  class Dog
  {
  }

  class Cat
  {
  }

  class Puffer
  {
  }

  class Pirahna
  {
  }

  class Eagle
  {
  }

  class Sparrow
  {
  }


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
