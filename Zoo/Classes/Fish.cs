using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
  /// <summary>
  /// inherits from Animal
  /// has interface for Swim
  /// overrides Coating
  /// creates virtual method unique to Fish
  /// and creates virtual property unique to Fish
  /// </summary>
  abstract public class Fish : Animal, ICanSwim
  {
    //1st virtual property
    //found only in Fish
    //assumes default value of false unless
    //overriden (in Puffer)
    public virtual bool Poison { get { return false; } }
    //2nd virtual method
    //logs string out to console depending on Poisoin status
    //overriden in Pirahna
    public virtual string WillItPoisonYou(bool poison)
    {
      if (poison)
      {
        return("You died from eating this fish");
      }
      else
      {
        return ("You can eat this fish");
      }
    }

    public void SwimSpeed()
    {
      Console.WriteLine("Fishes swim fast enough");
    }

    public void ThisAnimalSwims()
    {
      Console.WriteLine("All Fishes can swim");
    }

    public override string Coating
    {
      get { return "Scales"; }
    }
  }

  /// <summary>
  /// inherits from Fish
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// overrides virtual property Poison
  /// </summary>
  abstract public class Puffer : Fish
  {
    bool _poison = true;
    protected string _name;
    protected int _age;
    Random lifeSpan = new Random();
    public override bool Poison { get { return _poison; } }
    public override string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public override int Age
    {
      get { return _age; }
      set { _age = value; }
    }
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(8, 25);
    }
    public override string MakeSound()
    {
      return ($"{Name} goes beleeep");
    }
  }
  /// <summary>
  /// for instantiating a version of Puffer
  /// contains constructors
  /// </summary>
  public class Japanese : Puffer
  {
    public Japanese()
    {
      _name = "No Name";
      _age = 0;
    }
    public Japanese(string name, int age)
    {
      _name = name;
      _age = age;
    }
    /// <summary>
    /// similar concept as previous classes
    /// </summary>
    public static void WhatAnimal()
    {
      Console.WriteLine("This is a the dangerous Japanese Puffer Fish");
    }
  }
  /// <summary>
  /// inherits from Fish
  /// has Pet Interface
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// overrides virtual property Poison and virtual method
  /// </summary>
  abstract public class Pirahna : Fish, ICanKeepPet
  {
    protected string _name;
    protected int _age;
    Random lifeSpan = new Random();
    public override string Name
    {
      get { return _name; }
      set { _name = value; }
    }
    /// <summary>
    /// pirahna not poison
    /// overrides else Console.Writeline
    /// </summary>
    /// <param name="poison">true/false on whether fish is poison</param>
    public override string WillItPoisonYou(bool poison)
    {
      if (poison)
      {
        return ("You died from eating this fish");
      }
      else
      {
        return ("You can eat this fish. Pirahnas are actually great in soup or grilled.");
      }
    }
    /// <summary>
    /// overrides age to for user to set
    /// </summary>
    public override int Age
    {
      get { return _age; }
      set { _age = value; }
    }
    /// <summary>
    /// same as previous methods with unqique lifespan range
    /// </summary>
    /// <returns></returns>
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(4, 25);
    }
    /// <summary>
    /// prints out unique statement
    /// </summary>
    /// <returns></returns>
    public override string MakeSound()
    {
      return ($"{Name} goes bloooop");
    }
    /// <summary>
    /// interface method for pet printout
    /// </summary>
    public void ThisAnimalCanBePet()
    {
      Console.WriteLine("You can maybe keep pirahnas as a pet. I wouldn't recommend it");
    }
    /// <summary>
    /// interface method for pet rating
    /// </summary>
    /// <returns></returns>
    public int PetRating()
    {
      return 4;
    }
  }
  /// <summary>
  /// for instantiating a version of Pirahna
  /// </summary>
  public class Brazilian : Pirahna
  {
    /// <summary>
    /// for instantiating class with no parameters
    /// </summary>
    public Brazilian()
    {
      _name = "No Name";
      _age = 0;
    }
    public Brazilian(string name, int age)
    {
      _name = name;
      _age = age;
    }
    /// <summary>
    /// for instantiating a version of Pirahna
    /// </summary>
    public static void WhatAnimal()
    {
      Console.WriteLine("This pirahna is found in the Amazon River in Brazil.");
    }
  }
}
