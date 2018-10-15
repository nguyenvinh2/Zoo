using System;

namespace Zoo
{
  abstract class Animal
  {
    abstract public string Name { get; set; }
    abstract public int Age { get; set; }
    abstract public string Coating { get; }
    abstract public int ExpectedLifeSpan();
    abstract public void MakeSound();

  }

  abstract class Mammal: Animal
  {
    public virtual void Action()
    {
      Console.WriteLine($"{Name} wants to love you");
    }
    public override string Coating
    {
      get { return "Fur"; }
    }
  }

  abstract class Fish: Animal
  {
    public virtual bool Poison { get { return false; } }
    public virtual void WillItPoisonYou(bool poison)
    {
      if (poison)
      {
        Console.WriteLine("You died from eating this fish");
      }
      else
      {
        Console.WriteLine("You can eat this fish");
      }
    }
    public override string Coating
    {
      get { return "Scales"; }
    }
  }

  abstract class Aves : Animal
  {
    public virtual int FlightSpeed { get; set;}
    public override string Coating
    {
      get { return "Feathers"; }
    }
  }

  abstract class Dog : Mammal
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
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(10, 13);
    }

    public override void MakeSound()
    {
      Console.WriteLine($"{Name} goes woof");
    }
  }

  class Domesticated: Dog
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

    public static void WhatAnimal()
    {
      Console.WriteLine("This is a pet dog");
    }
  }


  abstract class Cat: Mammal
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
    public override int ExpectedLifeSpan()
    {
      return lifeSpan.Next(2, 16);
    }

    public override void MakeSound()
    {
      Console.WriteLine($"{Name} goes meoow");
    }

    public override void Action()
    {
      Console.WriteLine($"{Name} wants to kill you");
    }
  }

  class HouseCat : Cat
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

    public static void WhatAnimal()
    {
      Console.WriteLine("This is a House Cat");
    }
  }

  abstract class Puffer: Fish
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
      return lifeSpan.Next(8,25);
    }
    public override void MakeSound()
    {
      Console.WriteLine($"{Name} goes beleeep");
    }

    public Puffer()
    {
      _name = "No Name";
      _age = 0;
    }
    public Puffer(string name, int age)
    {
      _name = name;
      _age = age;
    }
  }

  class Japanese : Puffer
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

    public static void WhatAnimal()
    {
      Console.WriteLine("This is a the dangerous Japanese Puffer Fish");
    }
  }

  abstract class Pirahna: Fish
  {
    protected string _name;
    protected int _age;
    Random lifeSpan = new Random();
    public override string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public override void WillItPoisonYou(bool poison)
    {
      if (poison)
      {
        Console.WriteLine("You died from eating this fish");
      }
      else
      {
        Console.WriteLine("You can eat this fish. Pirahnas are actually great in soup or grilled.");
      }
    }

    public override int Age
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
      Console.WriteLine($"{Name} goes bloooop");
    }
    public Pirahna()
    {
      _name = "No Name";
      _age = 0;
    }
    public Pirahna(string name, int age)
    {
      _name = name;
      _age = age;
    }
  }

  class Brazilian : Pirahna
  {
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

    public static void WhatAnimal()
    {
      Console.WriteLine("This pirahna is found in the Amazon River in Brazil.");
    }
  }

  abstract class CrownEagle: Aves
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
      return lifeSpan.Next(14,36);
    }
    public override void MakeSound()
    {
      Console.WriteLine($"{Name} goes Aaaaahhhh");
    }
  }

  class African: CrownEagle
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

  class Sparrow: Aves
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
    public override void MakeSound()
    {
      Console.WriteLine($"{Name} goes eeeechhh");  
    }
  }

  class OldWorld : Sparrow
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

    public static void WhatAnimal()
    {
      Console.WriteLine("The Old World Sparrows refer to their habitats in Africa, Asia, and Europe.");
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Domesticated Fluffy = new Domesticated("Fluffy", 2);
      Domesticated.WhatAnimal();
      Console.WriteLine($"{Fluffy.Name} is {Fluffy.Age} years old");
      Console.WriteLine($"{Fluffy.Name} is expected to live for {Fluffy.ExpectedLifeSpan()} years");
      Console.WriteLine($"{Fluffy.Name} has {Fluffy.Coating}");
      Fluffy.MakeSound();
      Fluffy.Action();
      Console.WriteLine();

      HouseCat Precious = new HouseCat("Precious", 7);
      HouseCat.WhatAnimal();
      Console.WriteLine($"{Precious.Name} is {Precious.Age} years old");
      Console.WriteLine($"{Precious.Name} has {Precious.Coating}");
      Console.WriteLine($"{Precious.Name} is expected to live for {Precious.ExpectedLifeSpan()} years");
      Precious.MakeSound();
      Precious.Action();
      Console.WriteLine();

      Japanese KnawKnaw = new Japanese("KnawKnaw", 5);
      Japanese.WhatAnimal();
      Console.WriteLine($"{KnawKnaw.Name} is {KnawKnaw.Age} years old");
      Console.WriteLine($"{KnawKnaw.Name} has {KnawKnaw.Coating}");
      Console.WriteLine($"{KnawKnaw.Name} is expected to live for {KnawKnaw.ExpectedLifeSpan()} years");
      KnawKnaw.MakeSound();
      KnawKnaw.WillItPoisonYou(KnawKnaw.Poison);
      Console.WriteLine();

      Brazilian CoCo = new Brazilian("CoCo", 4);
      Brazilian.WhatAnimal();
      Console.WriteLine($"{CoCo.Name} is {CoCo.Age} years old");
      Console.WriteLine($"{CoCo.Name} has {CoCo.Coating}");
      Console.WriteLine($"{CoCo.Name} is expected to live for {CoCo.ExpectedLifeSpan()} years");
      CoCo.MakeSound();
      CoCo.WillItPoisonYou(CoCo.Poison);
      Console.WriteLine();

      African America = new African("America", 8, 320);
      African.WhatAnimal();
      Console.WriteLine($"{America.Name} is {America.Age} years old");
      Console.WriteLine($"{America.Name} has {America.Coating}");
      Console.WriteLine($"{America.Name} is expected to live for {America.ExpectedLifeSpan()} years");
      Console.WriteLine($"{America.Name}'s top flight speed is {America.FlightSpeed}");
      America.MakeSound();
      Console.WriteLine();

      OldWorld Serene = new OldWorld("Sparrow", 8);
      OldWorld.WhatAnimal();
      Console.WriteLine($"{Serene.Name} is {Serene.Age} years old");
      Console.WriteLine($"{Serene.Name} has {Serene.Coating}");
      Console.WriteLine($"{Serene.Name} is expected to live for {Serene.ExpectedLifeSpan()} years");
      Console.WriteLine($"{Serene.Name}'s top flight speed is {Serene.FlightSpeed}");
      Serene.MakeSound();
      Console.WriteLine();

      Console.ReadKey();
    }
  }
}
