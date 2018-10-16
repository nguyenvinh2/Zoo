using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
  /// <summary>
  /// inherits from Animal
  /// overrides Coating
  /// and creates virtual property unique to Aves
  /// </summary>
  abstract public class Aves : Animal
  {
    //2nd virtual property
    //overriden in both types of bird
    //Sparrow and CrownEagle
    //Sparrow returns a set value
    //CrownEagle value requires user to input argument
    //so different number of parameters is need for input
    //(3 in African, 2 in OldWorld
    public virtual int FlightSpeed { get; set; }
    public override string Coating
    {
      get { return "Feathers"; }
    }
  }

  /// <summary>
  /// inherits from Aves
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// overrides virtual property FlightSpeed
  /// </summary>
  abstract public class CrownEagle : Aves
  {
    protected string _name;
    protected int _age;
    protected int _flightSpeed;
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

    public override int FlightSpeed
    {
      get { return _flightSpeed; }
      set { _flightSpeed = value; }
    }
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(14, 36);
    }
    public override string MakeSound()
    {
      return ($"{Name} goes Aaaaahhhh");
    }
  }
  /// <summary>
  /// for instantiatiating a version of CrownEagle
  /// </summary>
  public class African : CrownEagle
  {
    public African()
    {
      _name = "No Name";
      _age = 0;
      _flightSpeed = 0;
    }
    public African(string name, int age, int flightspeed)
    {
      _name = name;
      _age = age;
      _flightSpeed = flightspeed;
    }

    public static void WhatAnimal()
    {
      Console.WriteLine("The Crowned Eagle is a large bird of prey resising in Sub-Sahran Africa");
    }
  }
  /// <summary>
  /// inherits from Aves
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// overrides virtual property FlightSpeed
  /// </summary>
  abstract public class Sparrow : Aves
  {
    protected string _name;
    protected int _age;
    protected int _flightSpeed = 28;
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
    public override int FlightSpeed
    {
      get { return _flightSpeed; }
      set { _flightSpeed = value; }
    }

    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(1, 5);
    }
    public override string MakeSound()
    {
      return ($"{Name} goes eeeechhh");
    }
  }
  /// <summary>
  /// for instantiating a version of Sparrow
  /// contains constructors
  /// </summary>
  public class OldWorld : Sparrow
  {
    public OldWorld()
    {
      _name = "No Name";
      _age = 0;
    }
    public OldWorld(string name, int age)
    {
      _name = name;
      _age = age;
    }
    /// <summary>
    /// description of animal
    /// </summary>
    public static void WhatAnimal()
    {
      Console.WriteLine("The Old World Sparrows refer to their habitats in Africa, Asia, and Europe.");
    }
  }
}
