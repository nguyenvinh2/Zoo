using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
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
    abstract public string MakeSound();
  }
}
