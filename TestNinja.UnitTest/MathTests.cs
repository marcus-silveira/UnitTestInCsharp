using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTest;

public class MathTests
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(3, 3, 6)]
    [InlineData(5, 3, 8)]
    public void Add_WhenCalled_ReturnsTheSumOfArguments(int num1, int num2, int result)
    {
        // Arrange
        var math = CreateMath();

        // Act
        var sut = math.Add(num1, num2);

        // Assert
        Assert.Equal(result, sut);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(3, 7, 7)]
    [InlineData(5, 3, 5)]
    public void Max_WhenCalled_ReturnsTheGreaterNumber(int num1, int num2, int result)
    {
        // Arrange
        var math = CreateMath();

        // Act
        var sut = math.Max(num1, num2);

        // Assert
        Assert.Equal(result, sut);
    }

    private static Math CreateMath()
    {
        return new Math();
    }
}