# Zoo

This is a demonstration of C# Object Oriented Principles utilizing different types of Animals as an example. 

## Overview

A Base Class of Animal is defined.

Three types of Animals: Fish Class, Aves Class, and Mammal Class is subsequently defined inheriting its properties and methods from Animal

Each type of Animals is broken down further with chain inheritance:

Fish: Pirahnas and Puffers
Aves: Sparrows and Crown Eagles
Mammals: Dogs and Cats

A Concrete Class is finally derived from each of those in order to instantiate and Animal object:

Pirahana -> Brazilian
Puffer -> Japanese
Sparrow -> OldWorld
CrownEagle -> African
Dog -> Domesticated
Cat -> HouseCat

## OOP Principles

### Abstraction: 
The concept of identifying and implementing common attributes present in multiple classes. The Animal Class has the MakeSound() and ExpectedLifeSpan() because all animals have that in common. The implementation of it will be different, however.

### Encapsulation: 
Containing and controlling the details (such as access or visibility) of implementation within a class. Utilizing the abstract class for Animals, Fish, Aves, and Mammal is a form of Encapsulation. Using protected properties in Dog, Cat classes is also Encapsulation.

### Inheritance: 
The act of using a Base Class to provide specific behavior and member states to derived classes. Fish, Aves, and Mammal all inherit the methods and properties from the Animal Class.

### Polymorphism: 
Being able to connect to the same base through different subsequent forms:

  Method Overloading: Each Concrete Class in this example gives the user the ability to instatiate a new object with no parameters passed or with some parameters passed (Name and Age in this case).

  Method Overriding: All of the abstract properties found in the Animal class will be overriding to provide custom behaviors. For example, the method ExpectedLifespan() will be overriden by the Dog, Cat, CrownEagle etc... class to provide the specific values for each class.

## Special Type: Interface

  Interface is like a contract that all classes that inherit it will follow. Interfaces will tell each inherit classes what to do while the specific implementation of how to do it will be define in the inherited class.

  For example, there are two interfaces: ICanSwim and ICanKeepPet

  ICanSwim defines two methods: SwimSpeed() and ThisAnimalSwims()
  ICanKeepPet defines two methods: ThisAnimalCanBePet() and PetRating()

  ICanSwim is inherited by: Fish and Dog Class. Each of those classes will contain the specific implementations of SwimSpeed() and ThisAnimalSwims() (in this case outputting console a message)

  ICanKeepPet is inheritied by: Dog, Pirahna, Cat, and Sparrow class. Their specific methods are also customed defined in each class (returning an integer and Console.WriteLine a message)

## Visual

![Console](Zoo_Diagram.jpg?raw=true "Output")
