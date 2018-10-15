using System;
using Xunit;
using Zoo;
using static Zoo.Program;

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
      Assert.InRange(TestSparrow.ExpectedLifeSpan(),1,5);
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
  }
}
