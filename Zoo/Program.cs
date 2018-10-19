using System;
using Zoo.Classes;

namespace Zoo
{
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
      Domesticated Annie = new Domesticated("Annie", 5);
      Domesticated.WhatAnimal();
      Console.WriteLine($"{Fluffy.Name} is {Fluffy.Age} years old");
      Console.WriteLine($"{Fluffy.Name} is expected to live for {Fluffy.ExpectedLifeSpan()} years");
      Console.WriteLine($"{Fluffy.Name} has {Fluffy.Coating}");
      Console.WriteLine(Fluffy.MakeSound());
      Fluffy.Action();
      Fluffy.ThisAnimalSwims();
      Fluffy.ThisAnimalCanBePet();
      Fluffy.SwimSpeed();
      Console.WriteLine();
      //For different instatiating of Domesticated
      Console.WriteLine($"{Annie.Name} is {Annie.Age} years old");
      Console.WriteLine($"{Annie.Name} is expected to live for {Annie.ExpectedLifeSpan()} years");
      Console.WriteLine($"{Annie.Name} has {Annie.Coating}");
      Console.WriteLine(Annie.MakeSound());
      Annie.Action();
      Console.WriteLine();
      //For HouseCat Cat
      HouseCat Precious = new HouseCat("Precious", 7);
      HouseCat.WhatAnimal();
      Console.WriteLine($"{Precious.Name} is {Precious.Age} years old");
      Console.WriteLine($"{Precious.Name} has {Precious.Coating}");
      Console.WriteLine($"{Precious.Name} is expected to live for {Precious.ExpectedLifeSpan()} years");
      Console.WriteLine(Precious.MakeSound());
      Precious.Action();
      Precious.ThisAnimalCanBePet();
      Console.WriteLine();
      //For Japanese Puffer
      Japanese KnawKnaw = new Japanese("KnawKnaw", 5);
      Japanese.WhatAnimal();
      Console.WriteLine($"{KnawKnaw.Name} is {KnawKnaw.Age} years old");
      Console.WriteLine($"{KnawKnaw.Name} has {KnawKnaw.Coating}");
      Console.WriteLine($"{KnawKnaw.Name} is expected to live for {KnawKnaw.ExpectedLifeSpan()} years");
      Console.WriteLine(KnawKnaw.MakeSound());
      Console.WriteLine(KnawKnaw.WillItPoisonYou(KnawKnaw.Poison));
      KnawKnaw.SwimSpeed();
      KnawKnaw.ThisAnimalSwims();
      Console.WriteLine();
      //For Brazilian Pirahna
      Brazilian CoCo = new Brazilian("CoCo", 4);
      Brazilian.WhatAnimal();
      Console.WriteLine($"{CoCo.Name} is {CoCo.Age} years old");
      Console.WriteLine($"{CoCo.Name} has {CoCo.Coating}");
      Console.WriteLine($"{CoCo.Name} is expected to live for {CoCo.ExpectedLifeSpan()} years");
      Console.WriteLine(CoCo.MakeSound());
      Console.WriteLine(CoCo.WillItPoisonYou(CoCo.Poison));
      CoCo.PetRating();
      CoCo.ThisAnimalCanBePet();
      CoCo.SwimSpeed();
      CoCo.ThisAnimalSwims();
      Console.WriteLine();
      ////For African CrownEagle
      African America = new African("America", 8, 320);
      African.WhatAnimal();
      Console.WriteLine($"{America.Name} is {America.Age} years old");
      Console.WriteLine($"{America.Name} has {America.Coating}");
      Console.WriteLine($"{America.Name} is expected to live for {America.ExpectedLifeSpan()} years");
      Console.WriteLine($"{America.Name}'s top flight speed is {America.FlightSpeed}");
      Console.WriteLine(America.MakeSound());
      Console.WriteLine();
      //For OldWorld Sparrow
      OldWorld Serene = new OldWorld("Sparrow", 8);
      OldWorld.WhatAnimal();
      Console.WriteLine($"{Serene.Name} is {Serene.Age} years old");
      Console.WriteLine($"{Serene.Name} has {Serene.Coating}");
      Console.WriteLine($"{Serene.Name} is expected to live for {Serene.ExpectedLifeSpan()} years");
      Console.WriteLine($"{Serene.Name}'s top flight speed is {Serene.FlightSpeed}");
      Console.WriteLine(Serene.MakeSound());
      Serene.PetRating();
      Serene.ThisAnimalCanBePet();
      Console.WriteLine();

      Console.WriteLine(typeof(Japanese).GetInterface("ICanSwim"));

      Console.ReadKey();
    }
  }
}
