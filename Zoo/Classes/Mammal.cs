using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
  /// <summary>
  /// inherits from Animal
  /// overrides Coating
  /// creates virtual method unique to Mammal
  /// </summary>
  abstract public class Mammal : Animal
  {
    //1st virtual method
    //found only in Mammals
    //so only Dog and Cat inherits it
    //it is overriden in Cat but not in dog
    public virtual void Action()
    {
      Console.WriteLine($"{Name} wants to love you");
    }
    public override string Coating
    {
      get { return "Fur"; }
    }
  }

  /// <summary>
  /// inherits from Mammal
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// </summary>
  abstract public class Dog : Mammal
  {
    //made protected to pass values to inherit class
    protected string _name;
    protected int _age;
    Random lifeSpan = new Random();
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
      return lifeSpan.Next(10, 13);
    }

    public override string MakeSound()
    {
      return ($"{Name} goes woof");
    }
  }
  /// <summary>
  ///   /// last of derived class
  /// for instantiating a version of Dog
  /// </summary>
  public class Domesticated : Dog
  {
    public Domesticated()
    {
      _name = "No Name";
      _age = 0;
    }
    public Domesticated(string name, int age)
    {
      _name = name;
      _age = age;
    }
    /// <summary>
    /// describes animal. same method for every concrete method
    /// but prints out unique line
    /// </summary>
    public static void WhatAnimal()
    {
      Console.WriteLine("This is a pet dog");
    }
  }

  /// <summary>
  ///inherits from Mammal
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// overrides virtual Action()
  /// </summary>
  abstract public class Cat : Mammal
  {
    protected string _name;
    protected int _age;
    Random lifeSpan = new Random();
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
    /// <summary>
    /// because of the random
    /// this will return a different value everytime it is called
    /// </summary>
    /// <returns></returns>
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(2, 16);
    }
    /// <summary>
    /// override to return a string
    /// this is repeated for every animal for with different sounds
    /// </summary>
    /// <returns></returns>
    public override string MakeSound()
    {
      return ($"{Name} goes meoow");
    }
    /// <summary>
    /// unique override for Cat class
    /// </summary>
    public override void Action()
    {
      Console.WriteLine($"{Name} wants to kill you");
    }
  }
  /// <summary>
  /// last of derived class
  /// for instantiating a version of Cat
  /// </summary>
  public class HouseCat : Cat
  {
    public HouseCat()
    {
      _name = "No Name";
      _age = 0;
    }
    public HouseCat(string name, int age)
    {
      _name = name;
      _age = age;
    }
    /// <summary>
    /// prints out description of animal
    /// </summary>
    public static void WhatAnimal()
    {
      Console.WriteLine("This is a House Cat");
    }
  }
}
