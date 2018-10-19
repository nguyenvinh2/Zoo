using System;
using Xunit;
using Zoo;
using static Zoo.Program;
using Zoo.Classes;

namespace XUnitTestZoo
{
  public class UnitTest1
  {
    /// <summary>
    /// HouseCat should have fur
    /// </summary>
    [Fact]
    public void HouseCatFurTest()
    {
      HouseCat TestCat = new HouseCat();
      Assert.Equal("Fur", TestCat.Coating);
    }
    /// <summary>
    /// HouseCat lifespan from 2-16 years
    /// </summary>
    [Fact]
    public void HouseCatLifeExpectancyTest()
    {
      HouseCat TestCat = new HouseCat();
      Assert.InRange(TestCat.ExpectedLifeSpan(), 2, 16);
    }

    /// <summary>
    /// Domesticated Dog should have fur
    /// </summary>
    [Fact]
    public void DomesticatedDogFurTest()
    {
      Domesticated TestDog = new Domesticated();
      Assert.Equal("Fur", TestDog.Coating);
    }

    /// <summary>
    /// Test dog life span is within 10-13
    /// </summary>
    [Fact]
    public void DomesticatedLifeExpectancyTest()
    {
      Domesticated TestDog = new Domesticated();
      Assert.InRange(TestDog.ExpectedLifeSpan(), 10, 13);
    }
    /// <summary>
    /// Brazilian Pirahna should have scales
    /// </summary>
    [Fact]
    public void BrazilianPirahnaCoatTest()
    {
      Brazilian TestPirahna = new Brazilian();
      Assert.Equal("Scales", TestPirahna.Coating);
    }
    /// <summary>
    /// Brazilian puffer should live anywhere from 4-25
    /// </summary>
    [Fact]
    public void BrazilianLifeExpectancyTest()
    {
      Brazilian TestPuffer = new Brazilian();
      Assert.InRange(TestPuffer.ExpectedLifeSpan(), 4, 25);
    }
    /// <summary>
    /// Japanese Puffer should have scales
    /// </summary>
    [Fact]
    public void JapanesePufferCoatTest()
    {
      Japanese TestPuffer = new Japanese();
      Assert.Equal("Scales", TestPuffer.Coating);
    }
    /// <summary>
    /// Puffer lifespan range from 8-25
    /// </summary>
    [Fact]
    public void JapaneseLifeExpectancyTest()
    {
      Japanese TestPuffer = new Japanese();
      Assert.InRange(TestPuffer.ExpectedLifeSpan(), 8, 25);
    }
    /// <summary>
    /// African eagle should have feathers
    /// </summary>
    [Fact]
    public void AfricanCrownEagleCoatTest()
    {
      African TestEagle = new African();
      Assert.Equal("Feathers", TestEagle.Coating);
    }
    /// <summary>
    /// check to see if sparrow randomizer in within range 14-36
    /// </summary>
    [Fact]
    public void AfricanLifeExpectancyTest()
    {
      African TestEagle = new African();
      Assert.InRange(TestEagle.ExpectedLifeSpan(), 14, 36);
    }
    /// <summary>
    /// sparrow have feathers
    /// </summary>
    [Fact]
    public void OldWorldSparrowCoatTest()
    {
      OldWorld TestSparrow = new OldWorld();
      Assert.Equal("Feathers", TestSparrow.Coating);
    }
    /// <summary>
    /// check to see if sparrow randomizer in within range
    /// </summary>
    [Fact]
    public void OldWorldSparrowLifeExpectancyTest()
    {
      OldWorld TestSparrow = new OldWorld();
      Assert.InRange(TestSparrow.ExpectedLifeSpan(), 1, 5);
    }
    [Fact]
    public void OldWorldSparrowFlightTest()
    {
      OldWorld TestSparrow = new OldWorld();
      Assert.Equal(28, TestSparrow.FlightSpeed);
    }
    [Fact]
    public void CrownEagleFlightTest()
    {
      African TestEagle = new African();
      Assert.Equal(0, TestEagle.FlightSpeed);
    }
    /// <summary>
    /// tests if fish poison is false
    /// </summary>
    [Fact]
    public void PirahnaPoisonTest()
    {
      Brazilian TestPirahna = new Brazilian();
      Assert.False(TestPirahna.Poison);
    }
    /// <summary>
    /// tests if fish poison is true
    /// </summary>
    [Fact]
    public void PufferPoisonTest()
    {
      Japanese TestPuffer = new Japanese();
      Assert.True(TestPuffer.Poison);
    }

    /// <summary>
    /// tests if Puffer has ICanSwim Interface
    /// </summary>
    [Fact]
    public void InterfacePufferFish()
    {
      Japanese TestPuffer = new Japanese();
      Assert.True(TestPuffer is ICanSwim);
    }
    /// <summary>
    /// tests if pirahna implements pet rating
    /// should return number 4
    /// </summary>
    [Fact]
    public void InterfacePirahnaRatingTest()
    {
      Brazilian TestPirahna = new Brazilian();
      Assert.Equal(4, TestPirahna.PetRating());
    }
    /// <summary>
    /// tests if pirahna has ICanSwim interface
    /// </summary>
    [Fact]
    public void InterfacePirahnaSwimTest()
    {
      Brazilian TestPirahna = new Brazilian();
      Assert.True(TestPirahna is ICanSwim);
    }

    /// <summary>
    /// dog implements petrating and returns 10
    /// </summary>
    [Fact]
    public void InterfaceDogRatingTest()
    {
      Domesticated TestDog = new Domesticated();
      Assert.Equal(10, TestDog.PetRating());
    }

    [Fact]
    public void InterfaceCatRatingTest()
    {
      HouseCat TestCat = new HouseCat();
      Assert.Equal(9, TestCat.PetRating());
    }

    [Fact]
    public void InterfaceSparrowRatingTest()
    {
      OldWorld TestSparrow = new OldWorld();
      Assert.Equal(6, TestSparrow.PetRating());
    }
    /// <summary>
    /// Tests if Domesticated Dog came from Animal
    /// </summary>
    [Fact]
    public void ConcreteAnimalTestDog()
    {
      Domesticated TestDog = new Domesticated();
      Assert.True(TestDog is Animal);
    }
    /// <summary>
    /// Tests if Eagle is an Animal
    /// </summary>
    [Fact]
    public void ConcreteAnimalTestEagle()
    {
      African TestEagle = new African();
      Assert.True(TestEagle is Animal);
    }

    /// <summary>
    /// Original string is "You can eat this fish". Method override
    /// should change string to "You can eat this fish. Pirahnas are actually great in soup or grilled."
    /// </summary>
    [Fact]
    public void MethodOverridenTest()
    {
      Brazilian TestPirahna = new Brazilian();
      Assert.Equal("You can eat this fish. Pirahnas are actually great in soup or grilled.", TestPirahna.WillItPoisonYou(false));
    }
    /// <summary>
    /// Tests if Brazilian Pirahna inherits from Pirahna class
    /// </summary>
    [Fact]
    public void InheritancePirahna()
    {
      Brazilian TestPirahna = new Brazilian();
      Assert.True(TestPirahna is Pirahna);
    }

    /// <summary>
    /// Tests if Japanese Puffer inherits from Puffer class
    /// </summary>
    [Fact]
    public void InheritancePuffer()
    {
      Japanese TestPuffer = new Japanese();
      Assert.True(TestPuffer is Japanese);
    }

    /// <summary>
    /// Tests if OldWorld Sparrow inherits from Sparrow class
    /// </summary>
    [Fact]
    public void InheritanceSparrow()
    {
      OldWorld TestSparrow = new OldWorld();
      Assert.True(TestSparrow is Sparrow);
    }
  }
}
