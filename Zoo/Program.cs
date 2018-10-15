using System;

namespace Zoo
{
  /// <summary>
  /// Overall Base Class Animal
  /// </summary>
  abstract public class Animal
  {
    //Name, Age, Coating are abstract properties
    //Name and Age overriden 2 levels down
    //Coating overriden 1 level down
    abstract public string Name { get; set; }
    abstract public int Age { get; set; }
    abstract public string Coating { get; }
    //abstract methods
    //both overridden two level down
    abstract public int ExpectedLifeSpan();
    abstract public void MakeSound();
  }
  /// <summary>
  /// inherits from Animal
  /// overrides Coating
  /// creates virtual method unique to Mammal
  /// </summary>
  abstract public class Mammal: Animal
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
  /// inherits from Animal
  /// overrides Coating
  /// creates virtual method unique to Fish
  /// and creates virtual property unique to Fish
  /// </summary>
  abstract public class Fish: Animal
  {
    //1st virtual property
    //found only in Fish
    //assumes default value of false unless
    //overriden (in Puffer)
    public virtual bool Poison { get { return false; } }
    //2nd virtual method
    //logs string out to console depending on Poisoin status
    //overriden in Pirahna
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
    public virtual int FlightSpeed { get; set;}
    public override string Coating
    {
      get { return "Feathers"; }
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

    public override void MakeSound()
    {
      Console.WriteLine($"{Name} goes woof");
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
  abstract public class Cat: Mammal
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

    public static void WhatAnimal()
    {
      Console.WriteLine("This is a House Cat");
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
  abstract public class Puffer: Fish
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
  /// <summary>
  /// for instantiating a version of Puffer
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

    public static void WhatAnimal()
    {
      Console.WriteLine("This is a the dangerous Japanese Puffer Fish");
    }
  }
  /// <summary>
  /// inherits from Fish
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// overrides virtual property Poison and virtual method
  /// </summary>
  abstract public class Pirahna: Fish
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
  /// <summary>
  /// for instantiating a version of Pirahna
  /// </summary>
  public class Brazilian : Pirahna
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
  /// <summary>
  /// inherits from Aves
  /// declares property (protected)
  /// passes it on to derived class
  /// overrides ExpectedLifeSpan and MakeSound
  /// overrides Name and Age
  /// overrides virtual property FlightSpeed
  /// </summary>
  abstract public class CrownEagle: Aves
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
    public override void MakeSound()
    {
      Console.WriteLine($"{Name} goes eeeechhh");  
    }
  }
  /// <summary>
  /// for instantiating a version of Sparrow
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

    public static void WhatAnimal()
    {
      Console.WriteLine("The Old World Sparrows refer to their habitats in Africa, Asia, and Europe.");
    }
  }


  public class Program
  {
    /// <summary>
    /// instatiates every derived class
    /// and displays all of its polymorphic properties and methods
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //For Domesticated Dog
      Domesticated Fluffy = new Domesticated("Fluffy", 2);
      Domesticated.WhatAnimal();
      Console.WriteLine($"{Fluffy.Name} is {Fluffy.Age} years old");
      Console.WriteLine($"{Fluffy.Name} is expected to live for {Fluffy.ExpectedLifeSpan()} years");
      Console.WriteLine($"{Fluffy.Name} has {Fluffy.Coating}");
      Fluffy.MakeSound();
      Fluffy.Action();
      Console.WriteLine();
      //For HouseCat Cat
      HouseCat Precious = new HouseCat("Precious", 7);
      HouseCat.WhatAnimal();
      Console.WriteLine($"{Precious.Name} is {Precious.Age} years old");
      Console.WriteLine($"{Precious.Name} has {Precious.Coating}");
      Console.WriteLine($"{Precious.Name} is expected to live for {Precious.ExpectedLifeSpan()} years");
      Precious.MakeSound();
      Precious.Action();
      Console.WriteLine();
      //For Japanese Puffer
      Japanese KnawKnaw = new Japanese("KnawKnaw", 5);
      Japanese.WhatAnimal();
      Console.WriteLine($"{KnawKnaw.Name} is {KnawKnaw.Age} years old");
      Console.WriteLine($"{KnawKnaw.Name} has {KnawKnaw.Coating}");
      Console.WriteLine($"{KnawKnaw.Name} is expected to live for {KnawKnaw.ExpectedLifeSpan()} years");
      KnawKnaw.MakeSound();
      KnawKnaw.WillItPoisonYou(KnawKnaw.Poison);
      Console.WriteLine();
      //For Brazilian Pirahna
      Brazilian CoCo = new Brazilian("CoCo", 4);
      Brazilian.WhatAnimal();
      Console.WriteLine($"{CoCo.Name} is {CoCo.Age} years old");
      Console.WriteLine($"{CoCo.Name} has {CoCo.Coating}");
      Console.WriteLine($"{CoCo.Name} is expected to live for {CoCo.ExpectedLifeSpan()} years");
      CoCo.MakeSound();
      CoCo.WillItPoisonYou(CoCo.Poison);
      Console.WriteLine();
      ////For African CrownEagle
      African America = new African("America", 8, 320);
      African.WhatAnimal();
      Console.WriteLine($"{America.Name} is {America.Age} years old");
      Console.WriteLine($"{America.Name} has {America.Coating}");
      Console.WriteLine($"{America.Name} is expected to live for {America.ExpectedLifeSpan()} years");
      Console.WriteLine($"{America.Name}'s top flight speed is {America.FlightSpeed}");
      America.MakeSound();
      Console.WriteLine();
      //For OldWorld Sparrow
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
