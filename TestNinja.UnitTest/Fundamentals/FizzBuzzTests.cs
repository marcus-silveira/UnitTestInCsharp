using TestNinja.Fundamentals;

namespace TestNinja.UnitTest.Fundamentals;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(15, "FizzBuzz")]
    [InlineData(30, "FizzBuzz")]
    public void GetOutput_InputIsDivisibleBy3And5_ReturnsFizzBuzz(int number, string output)
    {
        // Act
        var fizzBuzz = FizzBuzz.GetOutput(number);

        // Assert
        Assert.Equal(output, fizzBuzz);
    }

    [Theory]
    [InlineData(18, "Fizz")]
    [InlineData(24, "Fizz")]
    public void GetOutput_InputIsDivisibleBy3_ReturnsFizz(int number, string output)
    {
        // Act
        var fizzBuzz = FizzBuzz.GetOutput(number);

        // Assert
        Assert.Equal(output, fizzBuzz);
    }

    [Theory]
    [InlineData(35, "Buzz")]
    [InlineData(10, "Buzz")]
    public void GetOutput_InputIsDivisibleBy5_ReturnsBuzz(int number, string output)
    {
        // Act
        var fizzBuzz = FizzBuzz.GetOutput(number);

        // Assert
        Assert.Equal(output, fizzBuzz);
    }

    [Theory]
    [InlineData(22, "22")]
    [InlineData(8, "8   ")]
    public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnsTheSameNumber(int number, string output)
    {
        // Act
        var fizzBuzz = FizzBuzz.GetOutput(number);

        // Assert
        Assert.Equal(output, fizzBuzz);
    }
}