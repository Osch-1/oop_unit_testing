using NUnit.Framework;

namespace TestingStuff.Tests;

public class RationalTests
{
    [Test]
    public void Rational_Constructor_NonRelativePrimeNumbers_NumeratorAndDenominatorPrimed()
    {
        //Arrange
        Rational rational;

        //Act
        rational = new Rational( 2, 6 );

        //Assert
        Assert.That( rational.Numerator, Is.EqualTo( 1 ) );
        Assert.That( rational.Denominator, Is.EqualTo( 3 ) );
    }
}