using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
  class Interfaces
  {
  }

  public interface ICanSwim
  {
    void SwimSpeed();
    void ThisAnimalSwims();
  }

  public interface ICanKeepPet
  {
    void ThisAnimalCanBePet();

    int PetRating();
  }
}
